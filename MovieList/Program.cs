using System;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goAgain;
            while (goAgain)
            {
                Console.WriteLine("Hello and Welcome to a very short list of movies!");
                try
                {


                    Console.WriteLine("Which genre would you like to see? animated, drama, horror, or scifi?");
                    string input = Console.ReadLine();
                    string userChoice = input.ToLower();
                }
                catch
                {
                    Console.WriteLine(@"I'm sorry you must enter ""animated"", ""drama"", ""horror"", or ""scifi""");
                }
            }
        }
    }
}
