using System;
using System.Collections.Generic;
using static MovieList.Blockbuster;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            while (goAgain)
            {
                //we're making a list and checking it ONCE
                //we're gonna find out who's smart or a dunce
                List<Movie> movies = new List<Movie>();
                movies.Add(new Movie("The Crowening", "horror"));
                movies.Add(new Movie("V for Vendetta", "scifi"));
                movies.Add(new Movie("Cars", "animated"));
                movies.Add(new Movie("The Room", "drama"));
                movies.Add(new Movie("Teeth", "horror"));
                movies.Add(new Movie("2001: A Space Oddity", "scifi"));
                movies.Add(new Movie("Wreck it Ralph", "animated"));
                movies.Add(new Movie("Cruel Intentions", "drama"));
                movies.Add(new Movie("Being John Malkovitch", "scifi"));
                movies.Add(new Movie("The Devil's Rejects", "Horror"));

                Console.WriteLine("Hello and Welcome to a very short list of movies!");
                try
                {
                    Console.WriteLine("Which genre would you like to see? animated, drama, horror, or scifi?");
                    string input = Console.ReadLine();
                    string userChoice = input.ToLower().Trim();
                    if (userChoice == "horror")
                    {
                        foreach (Movie m in movies)
                        {
                            if (m.Genre == "horror")
                            {
                                Console.WriteLine($"{m.Title}");
                            }
                        }
                    }
                    else if (userChoice == "animated")
                    {
                        foreach (Movie m in movies)
                        {
                            if (m.Genre == "animated")
                            {
                                Console.WriteLine($"{m.Title}");
                            }
                        }
                    }
                    else if (userChoice == "drama")
                    {
                        foreach (Movie m in movies)
                        {
                            if (m.Genre == "drama")
                            {
                                Console.WriteLine($"{m.Title}");
                            }
                        }
                    }
                    else if (userChoice == "scifi")
                    {
                        foreach (Movie m in movies)
                        {
                            if (m.Genre == "scifi")
                            {
                                Console.WriteLine($"{m.Title}");
                            }
                        }
                    }
                    else if (userChoice == "")
                    {
                        throw  new ArgumentNullException();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("C'mon man, work with me here");
                }
                catch
                {
                    Console.WriteLine(@"I'm sorry you must enter ""animated"", ""drama"", ""horror"", or ""scifi""");
                }
                try
                {
                    Console.WriteLine("\n\nWould you like to look at another genre?(y/n)");
                    char answer = char.Parse(Console.ReadLine());
                    if (char.ToLower(answer) == 'y')
                    {
                        goAgain = true;
                    }
                    else if (char.ToLower(answer) == 'n')
                    {
                        Console.WriteLine("Thanks for stopping by! Have a good one!");
                        goAgain = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine(@"I'm sorry, you must enter 'y' or 'n'");
                }


            }
        }
    }
}
