using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            //ThisIsPascalCase
            //thisIsCamelCase
            //this-is-kebab-case
            //this_is_snake_case

            //declare a variable
            bool IsDeclared;

            //initialize a variable(assign a value)
            IsDeclared = true;


        }
        [TestMethod] //testm and hit tab twice to autogen this test method
        public void Characters()
        {
            char character = 'A';
            char symbol = '?';
            char specialCharacter = '\n';
            //CR - Carriage Return
            //LF - Line Feed
        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte signedByteExample = 127;
            short shortExample = 32767;
            int intMin = -2147483648; //min value
            Int32 intMax = 2147483647; //max value
            long longExample = 3515135135;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.06455534384383843f;
            Console.WriteLine(1.543536546684668468168461846546565654645454648987979234381f);

            double doubleExample = 1.03558486988797546210303651644d;
            Console.WriteLine(doubleExample);//cw and tab twice

            decimal decimalExample = 1.006514615148654986594946981321684m;
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Croissant, Cookies, Danish, Bagguette, Scone};

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            Console.WriteLine(myPastry);
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime birthday = new DateTime(1997, 01, 30);
            Console.WriteLine(birthday);

            TimeSpan age = today - birthday;
        }
    }
}
