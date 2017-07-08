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

        private void Button_Clicked(object sender, EventArgs e)
        {
            var data = getDataAsync().Result.ToString();
            JObject jo = JObject.Parse(data);
            foreach(JProperty property in jo["location"].Children())
            {
                if(property.Equals("name"))
                    WeatherTitle.Text = property.Value.ToString();
            }
        }

        public async Task<object> getDataAsync()
        {
            string Url = "https://api.apixu.com/v1/current.json?key=3cf69de69a9a4af78bc151306170107&q=Santo%20Domingo";
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<object>(result);
        }
    }
}