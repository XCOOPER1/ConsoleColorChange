using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("g = green, r = red, b = blue, w = white ");
            int x = Console.Read();
            char userInput = Convert.ToChar(x);

            while (userInput != 'z')
            {
                switch (userInput)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }

                Console.Clear();
                Console.WriteLine("g = green, r = red, b = blue, w = white");
                x = Console.Read();
                userInput = Convert.ToChar(x);
            }

        }
    }
}
