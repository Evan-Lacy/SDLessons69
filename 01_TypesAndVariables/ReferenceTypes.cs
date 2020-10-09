using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    
    [TestClass]
    public class ReferenceTypes
    { 

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Strings()
        {
            string firstName = "Evan";
            string lastName = "Lacy";

            //concatenation
            string concatenatedFullName = firstName + " " + lastName;

            Console.WriteLine(concatenatedFullName);

            //compositing
            string compositeName = string.Format("man name is {0} {1} {2}", firstName, lastName, "hi");
            Console.WriteLine(compositeName);

            //interpolation
            string interpolation = $"{firstName} {lastName}";
        }

        [TestMethod]
        public void Classes()
        {
            Random randy = new Random();
            //randy is now an object of type/class Random
            int randomNumber = randy.Next(1, 11);
            Console.WriteLine(randomNumber);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "world", "why", "is it", "always", stringExample, "?" };
            string thirdExam = stringArray[2];
            Console.WriteLine(thirdExam);

            stringArray[0] = "hello there";
            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("hello");

            List<int> listOfInts = new List<int>();
            listOfInts.Add(456);

            int firstInt = listOfInts[0];

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm last");

            string firstItem = firstInFirstOut.Dequeue();
            string nextItem = firstInFirstOut.Dequeue();
            //string noItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            Console.WriteLine(nextItem);
            //Console.WriteLine(noItem);

            Dictionary<string, string> keyAndValue = new Dictionary<string, string>();
            keyAndValue.Add("name", "Evan");

            string name = keyAndValue["name"];
            Console.WriteLine(name);

            Dictionary<string, double> importantNumbers = new Dictionary<string, double>();
            importantNumbers.Add("e", 3.1415);

            //SortedList
            //HashSet
            //Stack

        }
    }
}
