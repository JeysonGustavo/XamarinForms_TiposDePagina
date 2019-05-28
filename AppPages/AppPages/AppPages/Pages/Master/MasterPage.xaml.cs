using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPages.Pages.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : MasterDetailPage
    {
		public MasterPage ()
		{
			InitializeComponent ();
		}

        private void MudarPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Navigation.Navigation_Home());
        }

        private void MudarPagina2(object sender, EventArgs args)
        {
            Detail = new Navigation.Navigation_Next();
        }

        private void MudarPagina3(object sender, EventArgs args)
        {
            Detail = new Conteudo();
        }
    }
}