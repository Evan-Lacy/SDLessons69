using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_Customer_Repo
{
    public class Customer
    {
        public string LastName { get; set; }

        public int IDNumber { get; set; }

        public int Age { get; set; }

        public DateTime EnrollDate { get; set; }

        public int YearsOfUse { get; set; }

        public Customer() { }

        public Customer(string lastName, int id, int age, DateTime enroll, int years)
        {
            LastName = lastName;
            IDNumber = id;
            Age = age;
            EnrollDate = enroll;
            YearsOfUse = years;
        }
    }
}
