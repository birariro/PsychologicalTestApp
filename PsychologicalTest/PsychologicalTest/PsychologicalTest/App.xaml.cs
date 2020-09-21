using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PsychologicalTest
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE5OTQyQDMxMzgyZTMyMmUzMFloNCtjUUtXL21NR1dnbTJZY2pVek5zTlY4ZGdueHZQVEhMWldFeFVhcVE9");

            InitializeComponent();

            MainPage = new NavigationPage(new Welcome());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
