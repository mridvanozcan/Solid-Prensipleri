using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class Addres
    {
        public string Street { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }

        public Addres(string street, string country, int postalCode)
        {
            Street = street;
            Country = country;
            PostalCode = postalCode;
        }
    }
}
