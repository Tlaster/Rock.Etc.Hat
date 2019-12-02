using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Rock.Etc.Hat.Avalonia.Controls.Paging;

namespace Rock.Etc.Hat.Avalonia.Activities
{
    public class WelcomeActivity : Activity
    {
        public WelcomeActivity()
        {
            AvaloniaXamlLoader.Load(this);
            this.FindControl<Button>("Button").Click += OnClick;
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            StartActivity<IndexActivity>();
        }
    }
}