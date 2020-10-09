using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while(total < 10)
            {
                Console.WriteLine(total);
                //total = total + 1;
                //total += 1;
                total++;
            }


            total = 0;
            while (true)
            {
                if(total == 10)
                {
                    Console.WriteLine("GOOOOOOOOOOOOOOOAAAAAAAAAAALLLLLLLL");
                    break;
                }
                total++;
            }

            Random randy = new Random();
            int counter;
            bool keepLooping = true;

            while (keepLooping)
            {
                counter = randy.Next(0, 20);

                if(counter == 6 || counter == 10)
                {
                    continue;
                }

                Console.WriteLine(counter);

                if(counter == 15){
                    keepLooping = false;
                }
            }

        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 31;

            //LCV = loop control variable
            //1 = start/setup
            //2 = "keep looping" condition
            //3 = do after each loop
            //4 = code executed each loop
            //        1             2         3
            for (int i =0; i <= studentCount; i++)
            {
                //4
                Console.WriteLine(i);
            }

            //for loops can be weird
            for (Random randy = new Random(); randy.Next(0, 10) != 8; Console.WriteLine("ahhh"))
            {

            }

            string[] instructors = { "Andrew", "Michael", "Josh", "Amanda" };
            for(int i = 0; i < instructors.Length; i++)
            {
                Console.WriteLine($"{instructors[i]} welcomes you!");
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            string[] instructors = { "Andrew", "Michael", "Josh", "Amanda" };
            foreach(string instructor in instructors)
            {
                Console.WriteLine(instructor);
            }
            foreach (char letter in "Evan Lacy")
            {
                Console.WriteLine(letter);
                Console.WriteLine("Evan Lacy"[3]);
            }
        }

        [TestMethod]
        public void DoWhileLoop()
        {
            int iterator = 0;

            do
            {
                Console.WriteLine("Hello!");
                Console.WriteLine(iterator++);
            }
            while (iterator <= 10);

            do
            {
                Console.WriteLine("Do this anyway");
            }
            while (false);
        }
    }
}
