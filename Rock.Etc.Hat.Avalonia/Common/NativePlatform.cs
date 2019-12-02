using System.Runtime.InteropServices;
using Rock.Etc.Hat.Platform.Core;
using Rock.Etc.Hat.Platform.Gtk;
using Rock.Etc.Hat.Platform.MacOS;
using Rock.Etc.Hat.Platform.Windows;

namespace Rock.Etc.Hat.Avalonia.Common
{
    internal static class NativePlatform
    {
        public static IPlatform GetNativePlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return new WindowsPlatform();
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return new MacOSPlatform();
            }

            return new GtkPlatform();
        }
    }
}