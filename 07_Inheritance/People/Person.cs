﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance.People
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Name 
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";
                //ternary expression
                return !string.IsNullOrWhiteSpace(fullName) ? fullName : "Unnamed";
            }
        }
    }
}
