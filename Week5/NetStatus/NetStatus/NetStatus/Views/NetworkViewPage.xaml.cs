using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetStatus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NetworkViewPage : ContentPage
    {
        public NetworkViewPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (CrossConnectivity.Current == null)
                return;
            
            ConnectionDetails.Text = CrossConnectivity.Current.ConnectionTypes.First().ToString();
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if(CrossConnectivity.Current != null)
                CrossConnectivity.Current.ConnectivityChanged -= Current_ConnectivityChanged;
        }

        private void Current_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if(CrossConnectivity.Current != null && CrossConnectivity.Current.ConnectionTypes != null)
                ConnectionDetails.Text = CrossConnectivity.Current.ConnectionTypes.FirstOrDefault().ToString();
        }
    }
}