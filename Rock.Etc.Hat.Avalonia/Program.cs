using Autofac;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Logging.Serilog;
using Rock.Etc.Hat.Avalonia.Common;

namespace Rock.Etc.Hat.Avalonia
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BuildAvaloniaApp().Start(AppMain, args);
        }

        public static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToDebug();
        }

        // Your application's entry point. Here you can initialize your MVVM framework, DI
        // container, etc.
        private static void AppMain(Application app, string[] args)
        {
            InitDIContainer();
            app.RunWithMainWindow<RootWindow>();
        }

        private static void InitDIContainer()
        {
            var builder = new ContainerBuilder();
            var platform = NativePlatform.GetNativePlatform();
            platform.Initialization(builder);
            Global.Container = builder.Build();
        }
    }
}