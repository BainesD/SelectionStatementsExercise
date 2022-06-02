﻿using System;

namespace SelectionsStatements1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessNumber();
            
            
            //var r = new Random();
            //var favNumber = r.Next(1,3);
            //Console.WriteLine("Can you guess what number I'm thinking of? It's between 1 and 1,000.");
            //int i = 0;
            

            //do
            //{
            //    var userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine("Too low, try again.");

            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine("Too high, try again.");
            //    }
            //    else if (userInput == favNumber)
            //    {
            //        Console.WriteLine("Correct! Nice Job!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid entry. Try again.");
            //    }
            //}
            //while (i == 0);

        }
        public static void GuessNumber()
        { 
            var r = new Random();
            var favnumber = r.Next(1,10);
            Console.WriteLine("Can you guess what number I'm thinking of? It's between 1 and 10");
            bool userInput = int.TryParse(Console.ReadLine(), out int num);

            if (num < 0 || num > 10 || !userInput)
            {
                Console.WriteLine("Silly human! I said a number between 1 and 10. Try again!");
                TryAgain();
            }
            else if (num < favnumber)
            {
                Console.WriteLine("Too low! Try again!");
                TryAgain();
            }
            else if (num > favnumber)
            {
                Console.WriteLine("Too high! Try again!");
                TryAgain();
            }
            else if (num == favnumber)
            {
                Console.WriteLine("Yes! That's it!! Good job!");
            }


            void TryAgain()
            {
                bool userInput = int.TryParse(Console.ReadLine(), out int num);
               
                if (num < 0 || num > 10 || !userInput)
                {
                    Console.WriteLine("Silly human! I said a number between 1 and 10. Try again!");
                    TryAgain();
                }
                else if (num < favnumber)
                {
                    Console.WriteLine("Too low! Try again!");
                    TryAgain();
                }
                else if (num > favnumber)
                {
                    Console.WriteLine("Too high! Try again!");
                    TryAgain();
                }
                else if (num == favnumber)
                {
                    Console.WriteLine("Yes! That's it!! Good job!");
                }
            }
        }

    }
}