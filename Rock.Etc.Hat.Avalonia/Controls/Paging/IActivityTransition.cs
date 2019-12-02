using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Styling;

namespace Rock.Etc.Hat.Avalonia.Controls.Paging
{
    /// <summary>Enumeration of the possible activity insertion modes. </summary>
    public enum ActivityInsertionMode
    {
        /// <summary>
        ///     Inserts the new activity over the previous activity before starting the animations so that both activities are
        ///     in the visual tree during the animations.
        /// </summary>
        NewAbove,

        /// <summary>
        ///     Inserts the new activity below the previous activity before starting the animations so that both activities
        ///     are in the visual tree during the animations.
        /// </summary>
        NewBelow
    }

    public interface IActivityTransition
    {
        ActivityInsertionMode InsertionMode { get; }

        Task OnStart(Activity newActivity, Activity currentActivity);

        Task OnClose(Activity closeActivity, Activity previousActivity);
    }

    internal class DefaultActivityTransition : IActivityTransition
    {
        private readonly Animation _fadeInAnimation;
        private readonly Animation _fadeOutAnimation;

        public DefaultActivityTransition()
        {
            _fadeOutAnimation = new Animation
            {
                Children =
                {
                    new KeyFrame
                    {
                        Setters =
                        {
                            new Setter
                            {
                                Property = Visual.OpacityProperty,
                                Value = 0d
                            }
                        },
                        Cue = new Cue(1d)
                    }
                }
            };
            _fadeInAnimation = new Animation
            {
                Children =
                {
                    new KeyFrame
                    {
                        Setters =
                        {
                            new Setter
                            {
                                Property = Visual.OpacityProperty,
                                Value = 1d
                            }
                        },
                        Cue = new Cue(1d)
                    }
                }
            };
            _fadeOutAnimation.Duration = _fadeInAnimation.Duration = TimeSpan.FromSeconds(0.25);
        }

        public ActivityInsertionMode InsertionMode { get; } = ActivityInsertionMode.NewBelow;

        public async Task OnStart(Activity newActivity, Activity currentActivity)
        {
            if (currentActivity != null)
            {
                currentActivity.Opacity = 1;
                _fadeOutAnimation.RunAsync(currentActivity);
                currentActivity.Opacity = 0;
            }

            if (newActivity != null)
            {
                newActivity.Opacity = 0;
                await _fadeInAnimation.RunAsync(newActivity);
                newActivity.Opacity = 1;
            }
        }

        public async Task OnClose(Activity closeActivity, Activity previousActivity)
        {
            if (closeActivity != null)
            {
                closeActivity.Opacity = 1;
                _fadeOutAnimation.RunAsync(closeActivity);
                closeActivity.Opacity = 0;
            }

            if (previousActivity != null)
            {
                previousActivity.Opacity = 0;
                await _fadeInAnimation.RunAsync(previousActivity);
                previousActivity.Opacity = 1;
            }
        }
    }
}