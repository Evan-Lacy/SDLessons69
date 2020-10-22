﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class FunConsole : IConsole
    {
        public Random _randy = new Random();
        
        public void Clear()
        {
            Console.Clear();
        }

        public string ReadLine()
        {
            Console.WriteLine("Idiot Says");
            string input =  Console.ReadLine();
            string newInput = "";
            bool capitalize = false;
            foreach(char letter in input)
            {
                if (capitalize)
                {
                    newInput += letter.ToString().ToUpper();
                    capitalize = false;
                }
                else
                {
                    newInput += letter.ToString().ToUpper();
                    capitalize = true;
                }
            }
            return newInput;
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public void WriteLine(string s)
        {
            int colorPicker = _randy.Next(0, 7);
            switch (colorPicker)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    return;
            }
            Console.WriteLine("Simon Says");
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}
