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
            // Required for SingleFile with Windows App SDK servicing builds
            Environment.SetEnvironmentVariable(
                "MICROSOFT_WINDOWSAPPRUNTIME_BASE_DIRECTORY",
                AppContext.BaseDirectory);

            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
