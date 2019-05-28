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
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

        private async void BackPage(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }

        //desabilitar o botão de voltar no ANDROID na NavigationPage
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}