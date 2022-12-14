using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //navegar entre pestañas
            MainPage = new NavigationPage(new Login());
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
