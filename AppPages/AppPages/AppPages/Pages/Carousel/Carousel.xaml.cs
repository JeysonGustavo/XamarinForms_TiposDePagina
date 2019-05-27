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
	public partial class Carousel : CarouselPage
	{
		public Carousel ()
		{
			InitializeComponent ();
		}
	}
}