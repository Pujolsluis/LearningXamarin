using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorPrNavRev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.Title = "Color Processor Nav";
            redButton.Clicked += onButtonClicked;
		    blueButton.Clicked += onButtonClicked;
		    greenButton.Clicked += onButtonClicked;
		}

	    private void onButtonClicked(object sender, EventArgs eventArgs)
	    {
	        Button tempButton = (Button) sender;

            switch (tempButton.Text.ToLower())
	        {
                case "red":
                    Navigation.PushAsync(new ColoredPage(userEntry.Text, Color.Red));
                    break;
                case "blue":
                    Navigation.PushAsync(new ColoredPage(userEntry.Text, Color.Blue));
                    break;
                case "green":
                    Navigation.PushAsync(new ColoredPage(userEntry.Text, Color.Green));
                    break;
                default:
                    break;
	        }
	    }
	}
}
