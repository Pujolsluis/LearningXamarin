using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using FinalW2Rev.Models;

namespace FinalW2Rev.ViewModels
{
    class RegisterPageViewModel : INotifyPropertyChanged
    {
        private User user;

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

        public event PropertyChangedEventHandler PropertyChanged;

    }

}
