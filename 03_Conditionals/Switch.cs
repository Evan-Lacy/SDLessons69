using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    
    [TestClass]
    public class Switch
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

        enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday};

        [TestMethod]
        public void SwitchCases()
        {
            WeekDay today = WeekDay.Friday;

            switch(today)
            {
                case WeekDay.Monday:
                    Console.WriteLine("Somebody got a case of the Mondays?");
                    break;

                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                    Console.WriteLine("It's the middle of the week!");
                    break;
                case WeekDay.Friday:
                    Console.WriteLine("");
                    break;
            }

        }

        [TestMethod]
        public void SwitchExpressions()
        {
            string output;
            int action = 1;

            switch (action)
            {
                case 0:
                    output = "Case 0";
                    break;
                case 1:
                    output = "Case 1";
                    break;
                case 2:
                    output = "Case 2";
                    break;
                default:
                    output = "Default Case";
                    break;
            }

            Console.WriteLine(output);

            /*Switch Expression
            output = action switch
            {

            }*/
        }
    }
}
