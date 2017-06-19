﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FinalProjectWeek2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new Views.LoginPage());
            nav.BarBackgroundColor = Color.FromHex("1d2029");
            nav.BarTextColor = Color.White;
            nav.BackgroundColor = Color.White;
            MainPage = nav;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
