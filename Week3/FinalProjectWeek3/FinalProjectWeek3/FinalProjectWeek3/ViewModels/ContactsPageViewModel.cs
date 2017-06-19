using FinalProjectWeek3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectWeek3.ViewModels
{
    class ContactsPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contact> Contacts { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ContactsPageViewModel()
        {
            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact { Name = "Luis Pujols", PhoneNumber = "829-421-2414" });
            Contacts.Add(new Contact { Name = "Jennifer Pujols", PhoneNumber = "829-421-2413" });
        }
    }
}
