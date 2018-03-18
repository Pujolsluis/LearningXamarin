using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzIcAppRev.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SzIcAppRev.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashboardPage : ContentPage
	{
		public DashboardPage ()
		{
			InitializeComponent ();
		    BindingContext = new DashboardViewModel();

            smallButton.Clicked += onButtonClick;
		    mediumButton.Clicked += onButtonClick;
		    largeButton.Clicked += onButtonClick;
		}

	    private void onButtonClick(object sender, EventArgs eventArgs)
	    {
	        throw new NotImplementedException();
	    }
	}
}