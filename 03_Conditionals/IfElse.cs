using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 23;

            if (age > 142)
            {
                Console.WriteLine("You young");
            } else if (age >= 18)
            {
                Console.WriteLine("You're an adult, Harry");
            } else
            {
                Console.WriteLine("You dumb kid");
            }
        }
    }
}
