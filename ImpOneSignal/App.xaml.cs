using Com.OneSignal;
using Xamarin.Forms;

namespace ImpOneSignal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            OneSignal.Current.StartInit("8c78a8f2-3db7-4e4c-aadc-c50c5e434719")
                  .EndInit();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
