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
        public string ProvinceToSearch { get; set; }

        public WeatherPageView()
        {
            InitializeComponent();
            InitializePickerAsync();
            ProvinceToSearch = "Santo Domingo";
        }


        private async void InitializePickerAsync()
        {
            WeatherPicker.Title = "Select a Province";
            var pickerData = await GetProvinceQueryDataAsync();
            foreach(Result result in pickerData.result)
            {
                WeatherPicker.Items.Add(result.Province.name);
            }

            WeatherPicker.SelectedIndexChanged += (sender, args) =>
            {
                if (WeatherPicker.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    ProvinceToSearch = WeatherPicker.SelectedItem.ToString();
                }
            };

        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
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
            string Url ="https://api.apixu.com/v1/current.json?key=3cf69de69a9a4af78bc151306170107&q=" + System.Net.WebUtility.UrlEncode(ProvinceToSearch);
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<Weather>(result);
        }

        private async Task<ProvincesQuery> GetProvinceQueryDataAsync()
        {
            string Url = "https://www.menu.com.do/api/v1/provinces.json";
            HttpClient client = new HttpClient();
            string resultProvince = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<ProvincesQuery>(resultProvince);
        }
    }
}