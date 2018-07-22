using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class Registration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string ConfirmEmail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public Registration()
        {

        }

        public Registration(string firstname, string lastname, string username, string emailaddress,
            string confirmemail, string password, string confirmpassword)
        {
            FirstName = firstname;
            LastName = lastname;
            UserName = username;
            EmailAddress = emailaddress;
            ConfirmEmail = confirmemail;
            Password = password;
            ConfirmPassword = confirmpassword;
        }
    }
}