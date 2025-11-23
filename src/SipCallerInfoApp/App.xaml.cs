using Microsoft.UI.Xaml;

namespace SipCallerInfoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); // associates App.xaml resources with this App
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            var window = new MainWindow();
            window.Activate();
        }
    }
}
