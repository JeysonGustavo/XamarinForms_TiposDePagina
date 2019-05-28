using AppPages.Pages.Tabbed;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Master Detail
            MainPage = new Pages.Master.MasterPage();

            //Tabbed page
            //MainPage = new Tabbed();

            //chamada da NavigationPage
            //MainPage = new NavigationPage(new Pages.Navigation.WelcomePage()) {
            //    //alterar a cor de fundo e do texto da Navigation Bar
            //    BarTextColor = Color.White,
            //    BarBackgroundColor = Color.Gray
            //};
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
