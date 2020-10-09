using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string name = "Evan";
            bool isEvan = name.ToLower() == "evan";
            bool isForty = age == 40;

            Console.WriteLine("Did I just turn 40? " + isForty + " \n Is my name Evan? " + isEvan );

            bool isNotEighteen = age != 18;

            Console.WriteLine("Am I eighteen again? " + isNotEighteen);

            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool isOverOneHundred = age > 100;

            bool trueValue = true;
            bool falseValue = false;

            bool andValue = trueValue && falseValue;
            bool ofValue = trueValue || falseValue;

            bool isFive = 5 == Int32.Parse("5");

            //Arithmetic
            int remainder = 23 % 4;
            Console.WriteLine(remainder);


        }
    }
}
