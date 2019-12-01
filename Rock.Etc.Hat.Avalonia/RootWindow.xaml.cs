using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

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
        }
    }
}