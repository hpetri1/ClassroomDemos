using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class Entry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }


        public Entry()
        {

        }

        public Entry(string firstname, string lastname, string streetaddress1, string streetaddress2,
             string province, string city, string pc, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            StreetAddress1 = streetaddress1;
            StreetAddress2 = streetaddress2; 
            Province = province;
            City = city;
            PostalCode = pc;
            EmailAddress = email;
        }
    }
}