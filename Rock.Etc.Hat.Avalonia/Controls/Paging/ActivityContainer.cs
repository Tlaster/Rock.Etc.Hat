using System;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;

namespace Rock.Etc.Hat.Avalonia.Controls.Paging
{
    public class ActivityContainer : Grid
    {
        private readonly ActivityStackManager _activityStackManager = new ActivityStackManager();

        public ActivityContainer()
        {
            _activityStackManager.BackStackChanged += ActivityStackManagerOnBackStackChanged;
        }

        public bool DisableCache { get; set; }
        private ActivityModel CurrentActivityModel => _activityStackManager?.CurrentActivity;
        public Activity CurrentActivity => _activityStackManager?.CurrentActivity?.GetActivity(this);
        public bool CanGoBack => _activityStackManager.CanGoBack;
        public int BackStackDepth => _activityStackManager.BackStackDepth;
        public bool IsNavigating { get; private set; }
        public IActivityTransition ActivityTransition { get; set; }

        private IActivityTransition ActualActivityTransition
        {
            get
            {
                if (Transitions != null && Transitions.Any())
                {
                    return null;
                }

                var currentActivity = CurrentActivity;
                return currentActivity?.Transitions != null && currentActivity?.Transitions.Any() == true
                    ? CurrentActivity.ActivityTransition
                    : ActivityTransition;
            }
        }

        public event EventHandler<EventArgs> Navigated;
        public event EventHandler<EventArgs> Navigating;
        public event EventHandler BackStackChanged;

        private void ActivityStackManagerOnBackStackChanged()
        {
            BackStackChanged?.Invoke(this, EventArgs.Empty);
        }

        private Task<bool> NavigateWithMode(ActivityModel newActivity, NavigationMode navigationMode)
        {
            return RunNavigationWithCheck(async () =>
            {
                var currentActivity = CurrentActivityModel;

                _activityStackManager.ClearForwardStack();

                await NavigateImplAsync(navigationMode, currentActivity, newActivity,
                    _activityStackManager.CurrentIndex + 1);

                return true;
            });
        }

        private async Task<bool> RunNavigationWithCheck(Func<Task<bool>> task)
        {
            if (IsNavigating)
            {
                return false;
            }

            try
            {
                IsNavigating = true;
                return await task();
            }
            finally
            {
                IsNavigating = false;
            }
        }

        public void ClearBackStack()
        {
            _activityStackManager.ClearBackStack();
        }

        public void Navigate(Type type)
        {
        }

        public Task<bool> Navigate(Type activityType, object parameter)
        {
            var newActivity = new ActivityModel(activityType, parameter);
            return NavigateWithMode(newActivity, NavigationMode.New);
        }

        public Task<bool> Navigate<T>(object parameter = null) where T : Activity
        {
            return Navigate(typeof(T), parameter);
        }

        protected virtual void OnCurrentActivityChanged(Activity currentActivity, Activity newActivity)
        {
        }

        public Task<bool> GoBack()
        {
            return RunNavigationWithCheck(async () =>
            {
                await GoForwardOrBack(NavigationMode.Back);
                return true;
            });
        }

        internal void FinishActivity(Activity activity)
        {
            if (CurrentActivity == activity)
            {
                if (CanGoBack)
                {
                    GoBack();
                }
            }
            else
            {
                _activityStackManager.RemoveActivity(activity);
            }
        }


        private async Task GoForwardOrBack(NavigationMode navigationMode)
        {
            if (CanGoBack)
            {
                var currentActivity = CurrentActivityModel;
                var nextActivityIndex =
                    _activityStackManager.CurrentIndex - 1;
                var nextActivity = _activityStackManager.Activities[nextActivityIndex];

                await NavigateImplAsync(navigationMode, currentActivity, nextActivity, nextActivityIndex);

                _activityStackManager.ClearForwardStack();
            }
            else
            {
                throw new InvalidOperationException($"The {nameof(ActivityContainer)} cannot go back");
            }
        }

        private async Task NavigateImplAsync(NavigationMode navigationMode,
            ActivityModel currentActivity, ActivityModel nextActivity, int nextIndex)
        {
            IsHitTestVisible = false;

            InvokeLifecycleBeforeContentChanged(navigationMode, currentActivity, nextActivity);

            _activityStackManager.ChangeCurrentActivity(nextActivity, nextIndex);

            OnCurrentActivityChanged(currentActivity?.Activity, nextActivity?.Activity);

            Navigating?.Invoke(this, EventArgs.Empty);

            await UpdateContent(navigationMode, currentActivity, nextActivity);

            InvokeLifecycleAfterContentChanged(navigationMode, currentActivity, nextActivity);

            IsHitTestVisible = true;

            ReleaseActivity(currentActivity);

            Navigated?.Invoke(this, EventArgs.Empty);
        }


        private void AddActivityToContentRoot(NavigationMode navigationMode, ActivityInsertionMode insertionMode,
            Activity next)
        {
            switch (navigationMode)
            {
                case NavigationMode.New when insertionMode == ActivityInsertionMode.NewAbove:
                case NavigationMode.Back when insertionMode == ActivityInsertionMode.NewBelow:
                    Children.Add(next);
                    break;
                case NavigationMode.Back when insertionMode == ActivityInsertionMode.NewAbove:
                case NavigationMode.New when insertionMode == ActivityInsertionMode.NewBelow:
                    Children.Insert(0, next);
                    break;
            }
        }

        private async Task UpdateContent(NavigationMode navigationMode, ActivityModel currentActivity,
            ActivityModel nextActivity)
        {
            var animation = ActualActivityTransition;
            var current = currentActivity?.GetActivity(this);
            var next = nextActivity?.GetActivity(this);
            if (animation != null)
            {
                AddActivityToContentRoot(navigationMode, animation.InsertionMode, next);
                switch (navigationMode)
                {
                    case NavigationMode.New:
                        await animation.OnStart(next, current);
                        break;
                    case NavigationMode.Back:
                        await animation.OnClose(current, next);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(navigationMode), navigationMode, null);
                }

                Children.Remove(current);
            }
            else
            {
                if (Children.Any())
                {
                    Children[0] = next;
                }
                else
                {
                    Children.Add(next);
                }
            }
        }

        private void InvokeLifecycleBeforeContentChanged(NavigationMode navigationMode, ActivityModel currentActivity,
            ActivityModel nextActivity)
        {
            switch (navigationMode)
            {
                case NavigationMode.New:
                    currentActivity?.GetActivity(this)?.OnPause();
                    nextActivity?.GetActivity(this)?.OnStart();
                    break;
                case NavigationMode.Back:
                    currentActivity?.GetActivity(this)?.OnClose();
                    nextActivity?.GetActivity(this).OnRestart();
                    break;
                case NavigationMode.Forward:
                    break;
                case NavigationMode.Refresh:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(navigationMode), navigationMode, null);
            }
        }

        private void InvokeLifecycleAfterContentChanged(NavigationMode navigationMode, ActivityModel currentActivity,
            ActivityModel nextActivity)
        {
            switch (navigationMode)
            {
                case NavigationMode.New:
                    currentActivity?.GetActivity(this)?.OnStop();
                    nextActivity?.GetActivity(this)?.OnResume();
                    break;
                case NavigationMode.Back:
                    currentActivity?.GetActivity(this)?.OnDestroy();
                    nextActivity?.GetActivity(this).OnResume();
                    break;
                case NavigationMode.Forward:
                    break;
                case NavigationMode.Refresh:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(navigationMode), navigationMode, null);
            }
        }

        private void ReleaseActivity(ActivityModel activity)
        {
            if (activity != null &&
                (activity.Activity.NavigationCacheMode == NavigationCacheMode.Disabled || DisableCache))
            {
                activity.Release();
            }
        }
    }


    public enum NavigationMode
    {
        New,
        Back,
        Forward,
        Refresh
    }

    public enum NavigationCacheMode
    {
        Disabled,
        Required,
        Enabled
    }
}