using System;

namespace SelectionStatement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was your favorite subject in school?");
            string favSubject = Console.ReadLine();
            string input1 = favSubject.ToLower();
            switch (input1)
            {
                case "science":
                case "sicence":
                    Console.WriteLine("Ooo Science! Experiments are so fun!");
                    break;
                case "english":
                    Console.WriteLine("English! There's nothing like a good book");
                    break;
                case "math":
                case "mathematics":
                    Console.WriteLine("That's my favorite! I'm made of math!");
                    break;
                case "history":
                case "social studies":
                    Console.WriteLine("History is very cool! Have you ever heard of Ada Lovelace?");
                    break;
                case "art":
                case "fine arts":
                    Console.WriteLine("Art! Some people say software development is an art.");
                    break;
                default:
                    Console.WriteLine("I don't know that one, but I'm sure it's very interesting!");
                    break;

            }
        }
    }
}
