using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectWeek3.Models
{
    public class Contact : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
