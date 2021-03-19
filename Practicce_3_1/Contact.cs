using System;
using System.Collections.Generic;
using System.Text;

namespace Practicce_3_1
{
    public class Contact
    {
        public Contact(string firstName, string lastName, string fullName, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Number = number;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Number { get; set; }
    }
}
