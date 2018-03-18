using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SimpRegFormRev.Models;
using SimpRegFormRev.Views;
using Xamarin.Forms;

namespace SimpRegFormRev.ViewModels
{
    class RegisterPageViewModel : INotifyPropertyChanged
    {
        User user;

        public String FirstName
        {
            get { return user.FirstName; }
            set { user.FirstName = value; }
        }

        public String LastName
        {
            get { return user.LastName; }
            set { user.LastName = value; }
        }

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

        public String ConfirmPassword
        {
            get { return user.ConfirmPassword; }
            set { user.ConfirmPassword = value; }
        }

        public String AboutMe
        {
            get { return user.AboutMe; }
            set { user.AboutMe = value; }
        }

        public bool AcceptTerms
        {
            get { return user.AcceptTerms; }
            set { user.AcceptTerms = value; }
        }

        public Command register { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public RegisterPageViewModel()
        {
            user = new User()
            {
                FirstName = "Maria",
                LastName = "Gonzales",
                AboutMe = "Hi im a really friendly person"
            };
            register = new Command(registerAccount);
        }

        public void registerAccount()
        {
            if (String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(LastName) || String.IsNullOrEmpty(Password) ||
                String.IsNullOrEmpty(ConfirmPassword)
                || String.IsNullOrEmpty(AboutMe))
            {
                App.Current.MainPage.DisplayAlert("Error", "All fields must be completed", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Success!", "You have register correctly", "OK");
                App.Current.MainPage.Navigation.PushAsync(new DashboardPage());
            }
        }

    }
}
