using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using PropertyChanged;
using SzIcAppRev.Models;
using SzIcAppRev.Views;
using Xamarin.Forms;

namespace SzIcAppRev.ViewModels
{

    class LoginPageViewModel : INotifyPropertyChanged
    {
        User user;
        public string Email
        {
            get { return user.Email; }
            set { user.Email = value; }
        }
        public string Password
        {
            get { return user.Password; }
            set { user.Password = value; }
        }

        public Command login { get; set; }

        public LoginPageViewModel()
        {
            user = new User()
            {
                Email = "luispujolso@gmail.com"
            };

            login = new Command(loginCommand);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void loginCommand()
        {
            Application.Current.MainPage.Navigation.PushAsync(new DashboardPage());
        }

    }
}
