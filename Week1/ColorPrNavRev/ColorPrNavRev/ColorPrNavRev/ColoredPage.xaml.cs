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
	public partial class ColoredPage : ContentPage
	{
        private String userText;
        private Color color;

        public ColoredPage(String text, Color color)
        {
            InitializeComponent();

            this.Title = "Result";
            this.userText = text;
            this.color = color;

            baseLayoutContainer.BackgroundColor = color;
            colorString.Text = userText;
        }
    }
}