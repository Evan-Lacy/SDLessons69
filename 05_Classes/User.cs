using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class User
    {
        
        public DateTime BirthDate { get; set; }
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public User() { } //constructors are green to match the class name

        public User(string firstName, string lastName, int idNumber, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = idNumber;
            BirthDate = dob;
        }

        public int GetYears()
        {
            TimeSpan ageSpan = DateTime.Now - BirthDate;
            double totalAgeInYears = ageSpan.TotalDays / 365.241;
            int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears)); //floor round down to nearest whole number, ceiling is round up to nearest whole
            return yearsOfAge;
        }


        public string FullName() //methods are yellow
        {
          return FirstName + " " + LastName;
        }

    }
}
