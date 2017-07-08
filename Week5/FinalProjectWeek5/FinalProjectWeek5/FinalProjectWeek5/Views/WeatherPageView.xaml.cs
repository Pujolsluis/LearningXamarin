using FinalProjectWeek5.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProjectWeek5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPageView : ContentPage
    {
        public WeatherPageView()
        {
            InitializeComponent();
            
        }

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            var weather = await GetDataAsync();
            WeatherLocation.Text = "Welcome to Weather in " + weather.location.name + " App";
            WeatherImage.Source = "https:" + weather.current.condition.icon;
            WeatherTitle.Text = weather.current.condition.text;
            TempC.Text = weather.current.temp_c + "°" + "C";
            TempF.Text = weather.current.temp_f + "°" + "F";
        }

        private async Task<Weather> GetDataAsync()
        {
            string Url = "https://api.apixu.com/v1/current.json?key=3cf69de69a9a4af78bc151306170107&q=Santo%20Domingo";
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<Weather>(result);
        }
    }
}