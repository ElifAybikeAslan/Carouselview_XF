using Carouselview_XF.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carouselview_XF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EtkinlikPage : ContentPage
	{
		public EtkinlikPage ()
		{
			InitializeComponent ();

            EtkinlikCarouselView.ItemsSource = new EtkinlikData().EtkinlikModel;
		}
	}
}