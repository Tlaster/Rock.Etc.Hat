using Avalonia;
using Avalonia.Markup.Xaml;

namespace Rock.Etc.Hat.Avalonia
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}