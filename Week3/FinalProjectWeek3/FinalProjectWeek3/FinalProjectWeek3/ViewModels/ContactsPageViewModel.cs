using FinalProjectWeek3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProjectWeek3.ViewModels
{
    class ContactsPageViewModel : INotifyPropertyChanged
    {
        public const string ContactListKey = "contactListData";
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        public Command addContactToList { get; set; }

        Contact _itemSelected;
        public Contact ItemSelected
        {
            get
            {
                return _itemSelected;
            }
            set
            {
                _itemSelected = value;

                if (_itemSelected != null)
                {
                    var answer = callContactAsync(_itemSelected);
                    
                }

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ContactsPageViewModel()
        {
            var serializedContacts = Settings.ContactList;
            if (serializedContacts != String.Empty)
            {
                Contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(Settings.ContactList);
            }
            else
            {
                Contacts = new ObservableCollection<Contact>();
            }
            addContactToList = new Command(addContactCommand);
            MessagingCenter.Subscribe<ViewModels.AddContactPageViewModel, Contact>(this, "Contact", (sender, param) =>
            {
                Contacts.Add(param);
                Settings.ContactList = JsonConvert.SerializeObject(Contacts);
            });
        }

        public void addContactCommand()
        {
            App.Current.MainPage.Navigation.PushAsync(new Views.AddContactPage());
        }

        public async Task callContactAsync(Contact value)
        {
            var answer = await App.Current.MainPage.DisplayAlert("Call?", "Are you sure you want to call " + value.Name, "YES", "NO");
            if (answer)
                DependencyService.Get<ICallContact>().dialContact(value.PhoneNumber);
        }

    }
}
