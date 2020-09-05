using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TechSaturday
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start(
                "android=a3923c0d-ddd9-4240-b48c-3dbe38d096ba",
                typeof(Analytics),
                typeof(Crashes)
            );
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
