using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class Examples
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public string asdjfBASLKBFAL(string name, int num, Vehicle vehicle)
        {
            //string asafjbnsldkfjba = $"Hi, I'm {name} and I have {num} guinea pigs";
            return "Hi, I'm " + " and I have " + num + "guinea pigs";
        }

        //write a method that takes a number and writes to the console if it's odd or even

        public void isEven(int someNum)
        {
            int remainder = someNum % 2;

            if(remainder == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public enum Flavor { Vanilla, Chocolate, Skunks, Strawberry, Sewage, Neopolitan, Bubblegum};

        public bool DoesEvanLikeTheIceCreamFlavor(Flavor flav)
        {
            switch (flav)
            {
                case Flavor.Vanilla:
                case Flavor.Chocolate:
                case Flavor.Neopolitan:
                    return true;
                case Flavor.Skunks:
                case Flavor.Bubblegum:
                case Flavor.Sewage:
                case Flavor.Strawberry:
                    return false;
                default:
                    return false;
            }

        }
    }
}
