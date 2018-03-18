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
	        Button tempButton = (Button) sender;
	        switch (tempButton.Text.ToLower())
	        {
                case "small":
                    logoImage.Scale = 1;
                    break;
                case "medium":
                    logoImage.Scale = 1.5;
                    break;
                case "large":
                    logoImage.Scale = 2;
                    break;
                default:
                    break;
	        }
	        {
	                
	        }
	    }
	}
}