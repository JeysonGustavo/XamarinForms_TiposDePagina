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
	public partial class Navigation_Home : ContentPage
	{
		public Navigation_Home ()
		{
			InitializeComponent ();
		}

        private void ChangeNavigationPage(object sender, EventArgs args)
        {
            // chamar a página "Next" mantendo o histórico da página anterior
            Navigation.PushAsync(new Navigation_Next());
        }

        private void ShowModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Navigation_Modal());
        }
    }
}