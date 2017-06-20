using FinalProjectWeek3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProjectWeek3.ViewModels
{
    class AddContactPageViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Command AddContact { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public AddContactPageViewModel()
        {
            AddContact = new Command(async(x) => await addContactCommand());
        }

        private async Task addContactCommand()
        {
            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(PhoneNumber))
            {
                await App.Current.MainPage.DisplayAlert("Error", "All fields must be completed", "OK");
            }
            else
            {
                var answer = await App.Current.MainPage.DisplayAlert("Add?", "Do you wish to add this contact to your directory?", "YES", "NO");
                Contact newContact = new Contact { Name = Name, PhoneNumber = PhoneNumber };
                if (answer)
                    MessagingCenter.Send<ViewModels.AddContactPageViewModel, Contact>(this, "Contact", newContact);
                await App.Current.MainPage.Navigation.PopAsync();
            }

        }
    }
}
