using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class CSSGrid
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddressOne { get; set; }
        public string StreetAddressTwo { get; set; }
        public string City { get; set; }
        public int ProvinceValueField { get; set; }
        public string ProvinceDisplayField { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }


        public CSSGrid()
        {

        }

        public CSSGrid(string firstname, string lastname, string streetaddressone, string streetaddresstwo,
            string city, int provincevaluefield, string provincedisplayfield, string postalcode, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            StreetAddressOne = streetaddressone;
            StreetAddressTwo = streetaddresstwo;
            City = city;
            ProvinceValueField = provincevaluefield;
            ProvinceDisplayField = provincedisplayfield;
            PostalCode = postalcode;
            Email = email;
        }
    }
}