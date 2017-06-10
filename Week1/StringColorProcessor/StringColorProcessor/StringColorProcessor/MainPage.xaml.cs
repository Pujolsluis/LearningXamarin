using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StringColorProcessor
{
    public partial class MainPage : ContentPage
    {

        //Text Entry
        Entry textEntry = new Entry();

        //Text Label
        Label textLabel = new Label();

        public MainPage()
        {
            InitializeComponent();

            textLabel.FontSize = 24;

            //Main Stacklayout with default orientation vertical
            var mainLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = 16
            };

            //Text Entry
            textEntry.Placeholder = "Input a text";
            textEntry.Keyboard = Keyboard.Create(KeyboardFlags.All);

            // Creating the secondary Stacklayout and assigning its correct orientation
            var secondaryLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 72
            };

            //Creating buttons 
            var buttonRed = new Button
            {
                Text = "Red",
                BackgroundColor = Color.Red,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var buttonBlue = new Button
            {
                Text = "Blue",
                BackgroundColor = Color.Blue,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var buttonGreen = new Button
            {
                Text = "Black",
                BackgroundColor = Color.Green,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            //Adding the buttons to the secondary layout
            secondaryLayout.Children.Add(buttonRed);
            secondaryLayout.Children.Add(buttonBlue);
            secondaryLayout.Children.Add(buttonGreen);

            
            mainLayout.Children.Add(textEntry);
            mainLayout.Children.Add(secondaryLayout);
            mainLayout.Children.Add(textLabel);

            buttonRed.Clicked += Button_Clicked;
            buttonBlue.Clicked += Button_Clicked;
            buttonGreen.Clicked += Button_Clicked;

            this.Content = mainLayout;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button tempButton = (Button) sender;
            if(tempButton.BackgroundColor == Color.Red)
            {
                textLabel.Text = textEntry.Text;
                textLabel.TextColor = Color.Red;
            }else if(tempButton.BackgroundColor == Color.Blue)
            {
                textLabel.Text = textEntry.Text;
                textLabel.TextColor = Color.Blue;
            }
            else if(tempButton.BackgroundColor == Color.Green)
            {
                textLabel.Text = textEntry.Text;
                textLabel.TextColor = Color.Green;
            }
        }
    }
}
