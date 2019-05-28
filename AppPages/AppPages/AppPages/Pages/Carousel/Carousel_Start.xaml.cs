using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPages.Pages.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Carousel_Start : ContentPage
	{
		public Carousel_Start ()
		{
			InitializeComponent ();
		}

        private void CallNavigationPage(object sender, EventArgs args)
        {
            //trocar a página do carousel para o navigation, informando que essa página é um Navigation Page
            App.Current.MainPage = new NavigationPage(new Navigation.Navigation_Home());
        }

    }
}