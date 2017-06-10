using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StringColorProcessor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColoredPage : ContentPage
    {
        public ColoredPage(string entryText, Color bgColor)
        {
            InitializeComponent();

            //Base layout for the colored background
            var baseLayout = new ContentView
            {
                BackgroundColor = bgColor
            };

            //StackLayout for the centered text
            var stackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            //Label with the entry text
            var label = new Label
            {
                Text = entryText,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.White
            };

            stackLayout.Children.Add(label);
            baseLayout.Content = stackLayout;
            this.Content = baseLayout;
            
        }
    }
}