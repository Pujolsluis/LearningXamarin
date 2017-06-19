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
            AddContact = new Command(addContactCommand);
        }

        private void addContactCommand()
        {
            App.Current.MainPage.DisplayAlert("Accepted", "Tamo Bindeao!", "OK");

        }
    }
}
