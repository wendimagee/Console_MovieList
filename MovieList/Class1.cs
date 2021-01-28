using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        private string Title { get; set; }
        private string Genre { get; set; }

        public Movie(string Title, string Genre)
        {
            this.Title = Title;
            this.Genre = Genre;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre : {Genre}");

        }

    }
}
