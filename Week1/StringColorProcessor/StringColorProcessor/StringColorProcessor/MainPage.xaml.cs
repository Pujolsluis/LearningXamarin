﻿using System;
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

            buttonRed.Clicked += Button_ClickedAsync;
            buttonBlue.Clicked += Button_ClickedAsync;
            buttonGreen.Clicked += Button_ClickedAsync;

            this.Content = mainLayout;
        }

        //Async method to create a new page when any button is clicked
        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (tempButton.BackgroundColor == Color.Red)
            {
                /* Part 1 simple color processor app.
                textLabel.Text = textEntry.Text;
                textLabel.TextColor = Color.Red;
                */
                await this.Navigation.PushAsync(new ColoredPage(textEntry.Text, Color.Red));
            }
            else if (tempButton.BackgroundColor == Color.Blue)
            {
                /* Part 1 simple color processor app.
                textLabel.Text = textEntry.Text;
                textLabel.TextColor = Color.Blue;
                */
                await this.Navigation.PushAsync(new ColoredPage(textEntry.Text, Color.Blue));
            }
            else if (tempButton.BackgroundColor == Color.Green)
            {
                /* Part 1 simple color processor app.
                textLabel.Text = textEntry.Text;
                textLabel.TextColor = Color.Green;
                */
                await this.Navigation.PushAsync(new ColoredPage(textEntry.Text, Color.Green));
            }
            
        }
    }
}
