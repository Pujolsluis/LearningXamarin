using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorfulTextEditor
{
    public partial class MainPage : ContentPage
    {
        Label labelOutput = new Label();
        FormattedString fs = new FormattedString();
        Entry entryText = new Entry
        {
            Placeholder = "Input a text",
            HorizontalOptions = LayoutOptions.FillAndExpand
        };
        Picker sizePicker = new Picker
        {
            Title = "Choose a Size",
            HorizontalOptions = LayoutOptions.FillAndExpand
        };


        public MainPage()
        {        
            InitializeComponent();
            var mainStackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = 16
            };

            var firstStackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(8, 24, 8, 0)
            };

            var secondStackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(8, 0, 8, 0)
            };

            var thirdStackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 72,
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(0,16,0,0)
            };

            var labelText = new Label
            {
                Text = "Text",
                FontSize = 24
            };

            firstStackLayout.Children.Add(labelText);
            firstStackLayout.Children.Add(entryText);

            var labelPicker = new Label
            {
                Text = "Size",
                FontSize = 24
            };

            sizePicker.Items.Add("Small");
            sizePicker.Items.Add("Medium");
            sizePicker.Items.Add("Large");

            secondStackLayout.Children.Add(labelPicker);
            secondStackLayout.Children.Add(sizePicker);

            var redButton = new Button
            {
                Text = "Red",
                BackgroundColor = Color.Red,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var blueButton = new Button
            {
                Text = "Blue",
                BackgroundColor = Color.Blue,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var greenButton = new Button
            {
                Text = "Black",
                BackgroundColor = Color.Green,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            redButton.Clicked += Button_Clicked;
            blueButton.Clicked += Button_Clicked;
            greenButton.Clicked += Button_Clicked;

            thirdStackLayout.Children.Add(redButton);
            thirdStackLayout.Children.Add(blueButton);
            thirdStackLayout.Children.Add(greenButton);


            mainStackLayout.Children.Add(firstStackLayout);
            mainStackLayout.Children.Add(secondStackLayout);
            mainStackLayout.Children.Add(thirdStackLayout);
            mainStackLayout.Children.Add(labelOutput);
            this.Content = mainStackLayout;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var tempButton = (Button)sender;

            switch (sizePicker.SelectedIndex)
            {
                case 0:
                    fs.Spans.Add(new Span { Text = entryText.Text, ForegroundColor = tempButton.BackgroundColor, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) });
                    break;
                case 1:
                    fs.Spans.Add(new Span { Text = entryText.Text, ForegroundColor = tempButton.BackgroundColor, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) });
                    break;
                case 2:
                    fs.Spans.Add(new Span { Text = entryText.Text, ForegroundColor = tempButton.BackgroundColor, FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) });
                    break;
                default:
                    fs.Spans.Add(new Span { Text = entryText.Text, ForegroundColor = tempButton.BackgroundColor, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) });
                    break;
            }

            labelOutput.FormattedText = fs;
        }
    }
}
