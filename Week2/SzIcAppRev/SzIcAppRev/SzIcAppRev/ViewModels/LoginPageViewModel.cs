using System;
using System.Collections.Generic;
using System.Text;
using SzIcAppRev.Models;

namespace SzIcAppRev.ViewModels
{
    class LoginPageViewModel
    {
        User user;

        public string Email
        {
            get { return user.Email; }
            set { user.Email = value; }
        }
        public string Password
        {
            get { return user.Password; }
            set { user.Password = value; }
        }

        public LoginPageViewModel()
        {
            user = new User()
            {
                Email = "luispujolso@gmail.com"
            };
        }
    }
}
