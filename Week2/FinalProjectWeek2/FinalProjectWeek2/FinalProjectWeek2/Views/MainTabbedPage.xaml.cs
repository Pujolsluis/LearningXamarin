using FinalProjectWeek2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProjectWeek2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
            this.Title = "My Day App";
            BindingContext = new ViewModels.TabbedPageViewModel();
        }

        public MainTabbedPage(string firstName, string lastName, string email, string password)
        {
            InitializeComponent();
            if (!(String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password)))
            {
                FirstName.Text = firstName;
                LastName.Text = lastName;
                Email.Text = email;
                Password.Text = password;
            }
        }
    }
}