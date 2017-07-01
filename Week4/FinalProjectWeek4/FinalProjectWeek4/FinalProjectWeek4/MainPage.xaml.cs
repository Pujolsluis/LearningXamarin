using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProjectWeek4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(new TimeSpan(0, 0, 5), () => {
                titleLabel.Effects.Add(Effect.Resolve("myEffects.FontEffect"));
                titleLabel.Text = "My Draw View";
                return true; // runs again, or false to stop
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            Color tempColor = tempButton.BackgroundColor;
            if (tempColor.Equals(Color.Red)){
                myDrawView.DrawColor = Color.Red;
            }else if (tempColor.Equals(Color.Blue))
            {
                myDrawView.DrawColor = Color.Blue;
            }
            else if (tempColor.Equals(Color.Yellow))
            {
                myDrawView.DrawColor = Color.Yellow;
            }
            else if (tempColor.Equals(Color.Green))
            {
                myDrawView.DrawColor = Color.Green;
            }
            else if (tempColor.Equals(Color.Gray))
            {
                myDrawView.DrawColor = Color.Gray;
            }
            else if (tempColor.Equals(Color.SkyBlue))
            {
                myDrawView.DrawColor = Color.SkyBlue;
            }
        }
    }
}
