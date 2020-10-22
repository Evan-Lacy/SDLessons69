using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance.Animals
{
    public class Axolotl : Animal
    {
        public bool IsCute
        {
            get
            {
                Console.WriteLine("It's True, I am cute!!");
                return true;
            }
        }


        public Axolotl()
        {
            Console.WriteLine("Axolotl constructor");
        }

        public override void SayFurColor()
        {
            Console.WriteLine("I have no fur.");
        }
    }
}
