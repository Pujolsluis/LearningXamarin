using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using FinalW2Rev.Models;
using FinalW2Rev.Views;
using Xamarin.Forms;

namespace FinalW2Rev.ViewModels
{
    class LoginPageViewModel : INotifyPropertyChanged
    {
        User user;
        public String Email
        {
            get { return user.Email; }
            set { user.Email = value; }
        }
        public String Password
        {
            get { return user.Password; }
            set { user.Password = value; }
        }

        public ICommand login { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginPageViewModel()
        {
            user = new User()
            {
                Email = "luispujolso@gmail.com"
            };

            login = new Command(loginAccount);

        }

        public void loginAccount()
        {
            App.Current.MainPage.Navigation.PushAsync(new Views.TabbedPage());
        }

    }
}
