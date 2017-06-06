using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnSitePractice1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracticePage : ContentPage
    {
        public PracticePage()
        {
            InitializeComponent();
            var mainStackLayout = new StackLayout();
            mainStackLayout.Padding = 16;

            var labelTitle = new Label
            {
                Text = "Enter a Phoneword",
            };

            var entry = new Entry
            {
                Placeholder = "Name",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var buttonTranslate = new Button
            {
                Text = "Translate",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var buttonCall = new Button
            {
                Text = "Call 1-885-9262746",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            mainStackLayout.Children.Add(labelTitle);
            mainStackLayout.Children.Add(entry);
            mainStackLayout.Children.Add(buttonTranslate);
            mainStackLayout.Children.Add(buttonCall);

            buttonCall.Clicked += (sender, e) =>
            {
                entry.Text = buttonCall.Text;
            };

            buttonTranslate.Clicked += (sedner, e) =>
            {
                entry.Text = null;
            };


            this.Content = mainStackLayout;
        }

    }
}