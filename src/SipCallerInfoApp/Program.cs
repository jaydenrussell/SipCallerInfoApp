using System;
using System.Runtime.Versioning;

namespace SipCallerInfoApp
{
    [SupportedOSPlatform("windows10.0.19041.0")]
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable(
                "MICROSOFT_WINDOWSAPPRUNTIME_BASE_DIRECTORY",
                AppContext.BaseDirectory);

            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
