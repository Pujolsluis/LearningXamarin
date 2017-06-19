﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProjectWeek2.ViewModels
{
    class RegisterPageViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Command SignUp { get; set; }

        public RegisterPageViewModel()
        {
            FirstName = "Toy Bindiado";
            SignUp = new Command(signUpCommand);
        }

        private void signUpCommand()
        {
            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(LastName) || String.IsNullOrEmpty(Password) ||
                String.IsNullOrEmpty(Email))
            {
                App.Current.MainPage.DisplayAlert("Error", "You must complete all fields", "OK");
                Password = null;
            }
            else
            {
                App.Current.MainPage.Navigation.PushAsync(new Views.MainTabbedPage(FirstName,LastName, Email, Password));
            }
        }

        
    }
}
