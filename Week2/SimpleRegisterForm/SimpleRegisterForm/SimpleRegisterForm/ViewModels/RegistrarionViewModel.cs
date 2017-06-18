using SimpleRegisterForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleRegisterForm.ViewModels
{
    class RegistrarionViewModel : INotifyPropertyChanged
    {
        public User newUser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string description { get; set; }
        public bool acceptedTerms { get; set; }
        public Command signUp { get; set; }

        public RegistrarionViewModel()
        {
            newUser = new User();
            firstName = newUser.FirstName;
            lastName = newUser.LastName;
            password = newUser.Password;
            email = newUser.Email;
            confirmPassword = newUser.Password;
            description = newUser.Description;
            acceptedTerms = newUser.AcceptedTerms;
            signUp = new Command(signUpCommand);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void signUpCommand()
        {
            if((String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(email) ||
                String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword) || String.IsNullOrEmpty(description)))
            {
                App.Current.MainPage.DisplayAlert("Error", "Fields cannot be empty", "OK");
                password = null;
                confirmPassword = null;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Welcome", "Thank you for signing up!", "OK");
            }
        }
    }

}
