using SimpleRegisterForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRegisterForm.ViewModels
{
    class RegistrarionViewModel
    {
        public User newUser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string description { get; set; }
        public bool acceptedTerms { get; set; }

        public RegistrarionViewModel()
        {
            newUser = new User();
            firstName = newUser.FirstName;
            lastName = newUser.LastName;
            password = newUser.Password;
            confirmPassword = newUser.Password;
            description = newUser.Description;
            acceptedTerms = newUser.AcceptedTerms;
        }
    }
}
