using FinalProjectWeek3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProjectWeek3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            this.Title = "My Contacts";
            BindingContext = new ViewModels.ContactsPageViewModel();
        }

        private async Task onDeleteAction(object sender, EventArgs e)
        {
            var myViewModel = (ViewModels.ContactsPageViewModel)this.BindingContext;
            var menuItem = (MenuItem)sender;
            var param = (Contact)menuItem.CommandParameter;
            var answer = await App.Current.MainPage.DisplayAlert("Delete?", "Would you like to delete the contact: " + param.Name, "Yes", "No");
            if(answer)
                myViewModel.Contacts.Remove(param);
        }
    }
}