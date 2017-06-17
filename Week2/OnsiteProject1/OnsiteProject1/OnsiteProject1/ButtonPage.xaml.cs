using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnsiteProject1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            switch (tempButton.Text)
            {
                case "Small":
                    platformLogo.Scale = 1;
                    break;
                case "Medium":
                    platformLogo.Scale = 1.5;
                    break;
                case "Large":
                    platformLogo.Scale = 2.0;
                    break;
                default:
                    break;
            }
        }

    }
}