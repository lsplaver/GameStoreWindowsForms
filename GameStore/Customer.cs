using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameStore
{
    public class Customer
    {
        public Customer() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string lastName, string email) { FirstName = firstName; LastName = lastName; Email = email; }

        public string GetDisplayText() => FirstName + " " + LastName + " " + Email;
    }
}
