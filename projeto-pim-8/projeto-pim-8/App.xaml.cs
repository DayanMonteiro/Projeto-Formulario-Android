using projeto_pim_8.Services;
using projeto_pim_8.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projeto_pim_8
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
