using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NetStatus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (CrossConnectivity.Current.IsConnected)
            {
                MainPage = new NetStatus.Views.NetworkViewPage();
            }
            else
            {
                MainPage = new NetStatus.Views.NoNetworkPage();
            }
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
        }

        private void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                MainPage = new NetStatus.Views.NetworkViewPage();
            }
            else
            {
                MainPage = new NetStatus.Views.NoNetworkPage();
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
