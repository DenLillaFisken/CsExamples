using System;
using System.Collections.Generic;
using System.Text;

namespace WPF1_ContactList.Models
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //OBS! Bra att kunna!
        public string FullName => $"{FirstName} {LastName}";

        //OBS! MÅSTE lära mig konstruktor!
        public Contact(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

    }
}
