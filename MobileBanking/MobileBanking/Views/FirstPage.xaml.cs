using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileBanking.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileBanking.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstPage : ContentPageBase<FirstPageViewModel>
	{
		public FirstPage ()
		{
			InitializeComponent ();
		}
	}
}