using System;
using System.Collections.Generic;
using System.Text;

namespace SzIcAppRev.Models
{
    class User
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
