﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProjectWeek2.ViewModels
{
    class TabbedPageViewModel : INotifyPropertyChanged
    {
        public DateTime Date { get; set; }
        public Command OpenWebPage { get; set; }
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public TabbedPageViewModel()
        {
            OpenWebPage = new Command(openWebPageCommand);
            Date = DateTime.Now;
            Device.StartTimer(new TimeSpan(0, 0, 1), () => {
                Date = DateTime.Now;
                return true; // runs again, or false to stop
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void openWebPageCommand()
        {
            Device.OpenUri(new Uri("http://www.mytime.net.au/"));
        }
    }
}
