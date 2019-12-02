using System;
using Avalonia.Controls;
using Avalonia.Layout;

namespace Rock.Etc.Hat.Avalonia.Controls.Paging
{
    public class Activity : UserControl
    {
        public Activity()
        {
            HorizontalAlignment = HorizontalAlignment.Stretch;
            VerticalAlignment = VerticalAlignment.Stretch;
            HorizontalContentAlignment = HorizontalAlignment.Stretch;
            VerticalContentAlignment = VerticalAlignment.Stretch;
        }

        public NavigationCacheMode NavigationCacheMode { get; set; } = NavigationCacheMode.Required;
        public IActivityTransition ActivityTransition { get; set; }
        public ActivityContainer Container { get; internal set; }

        protected void Finish()
        {
            Container.FinishActivity(this);
        }

        protected void StartActivity(Type type, object parameter = null)
        {
            Container.Navigate(type, parameter);
        }

        protected void StartActivity<T>(object parameter = null) where T : Activity
        {
            StartActivity(typeof(T), parameter);
        }

        protected internal virtual void OnCreate(object parameter)
        {
        }

        protected internal virtual void OnStart()
        {
        }

        protected internal virtual void OnRestart()
        {
        }

        protected internal virtual void OnStop()
        {
        }

        protected internal virtual void OnResume()
        {
        }

        protected internal virtual void OnPause()
        {
        }

        protected internal virtual void OnClose()
        {
        }

        protected internal virtual void OnDestroy()
        {
        }
    }
}