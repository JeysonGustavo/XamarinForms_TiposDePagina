using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPages.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void NextPage(object sender, EventArgs args)
        {
            //fazendo o push para a próxima página da Navigation
            await Navigation.PushAsync(new IntroductionPage());
        }
    }
}