using Microsoft.UI.Xaml;

namespace SipCallerInfoApp
{
    public partial class App : Application
    {
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            var window = new MainWindow();
            window.Activate();
        }
    }
}
