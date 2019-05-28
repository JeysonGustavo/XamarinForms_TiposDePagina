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
	public partial class Navigation_Modal : ContentPage
	{
		public Navigation_Modal ()
		{
			InitializeComponent ();
		}

        private void CloseModal(object sender, EventArgs args)
        {
            //fechar navigation usando POP
            Navigation.PopModalAsync();
        }
    }
}