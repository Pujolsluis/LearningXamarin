using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinalProjectWeek2.ViewModels
{
    class LoginPageViewModel : INotifyPropertyChanged
    {
        public string User { get; set; }
        public string Password { get; set; }
        public Command SignIn { get; set; }
        public Command SignUp { get; set; }
        public LoginPageViewModel()
        {
            User = null;
            Password = null;
            SignIn = new Command(signInCommand);
            SignUp = new Command(signUpCommand);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void signInCommand()
        {
            if(String.IsNullOrEmpty(User) || String.IsNullOrEmpty(Password)){
                App.Current.MainPage.DisplayAlert("Error", "You must complete all fields", "OK");
                Password = null;
            }
            else
            {
                Views.MainTabbedPage tabPag = new Views.MainTabbedPage();
                tabPag.
                App.Current.MainPage.Navigation.PushAsync(new Views.MainTabbedPage(User,"","",Password));
            }
        }

        public void signUpCommand()
        {
            App.Current.MainPage.Navigation.PushAsync(new Views.RegisterPage());
        }
    }
}
