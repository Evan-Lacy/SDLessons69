using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    [TestClass]
    public class Challenge
    {


        [TestMethod]
        public void WordPrint()
        {
            string word =  "Supercalifragilisticexpialidocious";

            foreach (char c in word)
            {
                Console.WriteLine(c);
            }


            foreach (char f in word)
            {
                if (f == 'i')
                {
                    Console.WriteLine('i');
                }
                else if (f == 'l')
                {
                    Console.WriteLine('l');
                }
                else
                {
                    Console.WriteLine("Not an \"i\"");
                }
            }

            Console.WriteLine(word.Length);


        }
    }
}
