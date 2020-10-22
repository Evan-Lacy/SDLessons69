using System;
using System.Collections.Generic;
using _07_Inheritance.Animals;
using _07_Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonTests()
        {
            Person me = new Person();
            me.FirstName = "Evan";
            me.LastName = "Lacy";

            Employee dwight = new Employee(12345);
            dwight.FirstName = "Dwight";
            dwight.LastName = "Schrute";
            Console.WriteLine(dwight.Name);
            Console.WriteLine(dwight.EmployeeNumber);

            SalaryEmployee jim = new SalaryEmployee(354684, 456789);

            jim.FirstName = "Jim";
            jim.LastName = "Halpert";
            Console.WriteLine(jim.Name);
            Console.WriteLine(jim.EmployeeNumber);
            Console.WriteLine(jim.Salary);

            List<Employee> ListOfEmployee = new List<Employee>();
            ListOfEmployee.Add(dwight);
            ListOfEmployee.Add(jim);
            //ListOfEmployee.Add(me);
        }

        [TestMethod]
        public void AnimalTests()
        {
            //Animal animal = new Animal();
            Sloth sloth = new Sloth();
            Console.WriteLine(sloth.IsSlow);
            sloth.Move();
            sloth.SayFurColor();

            Axolotl axolotl = new Axolotl();
            Console.WriteLine(axolotl.IsCute);
            axolotl.Move();
            axolotl.SayFurColor();
            //axolotl.NumberOfLegs(4);
        }


    }
}
