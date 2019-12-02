using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Rock.Etc.Hat.Avalonia.Activities;
using Rock.Etc.Hat.Avalonia.Controls.Paging;

namespace Rock.Etc.Hat.Avalonia
{
    public class RootWindow : Window
    {
        public RootWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            this.FindControl<ActivityContainer>("RootActivityContainer").Navigate<WelcomeActivity>();
        }
    }
}