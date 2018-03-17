using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorPrEditRev
{
	public partial class MainPage : ContentPage
	{
	    
		public MainPage()
		{
			InitializeComponent();

            sizePicker.Items.Add("Small");
            sizePicker.Items.Add("Medium");
            sizePicker.Items.Add("Large");

            redButton.Clicked += buttonClicked;
		    blueButton.Clicked += buttonClicked;
		    greenButton.Clicked += buttonClicked;
		}

        FormattedString fs = new FormattedString();

	    private void buttonClicked(object sender, EventArgs eventArgs)
	    {
	        Button tempButton = (Button) sender;

	        switch (sizePicker.SelectedIndex)
	        {
                case 0:
                    fs.Spans.Add( new Span { Text = textEntry.Text, ForegroundColor = tempButton.BackgroundColor, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) } );
                    break;
                case 1:
                    fs.Spans.Add(new Span { Text = textEntry.Text, ForegroundColor = tempButton.BackgroundColor, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) });
                    break;
                case 2:
                    fs.Spans.Add(new Span { Text = textEntry.Text, ForegroundColor = tempButton.BackgroundColor, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) });
                    break;
                default:
                    fs.Spans.Add(new Span { Text = textEntry.Text, ForegroundColor = tempButton.BackgroundColor, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) });
                    break;
	        }

	        resultLabel.FormattedText = fs;

	    }
	}
}
