using Microsoft.UI.Xaml;
using System;
using System.Runtime.Versioning;

namespace SipCallerInfoApp
{
    [SupportedOSPlatform("windows10.0.19041.0")]
    internal static class EntryPoint
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Required for SingleFile (Windows App SDK servicing builds)
            Environment.SetEnvironmentVariable(
                "MICROSOFT_WINDOWSAPPRUNTIME_BASE_DIRECTORY",
                AppContext.BaseDirectory);

            // WinUI 3 entry point: starts the app and invokes your App class
            Application.Start((p) => new App());
        }
    }
}
