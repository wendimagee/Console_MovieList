using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Blockbuster
    {
        public enum Genre
        {
            Comedy,
            Horror,
            Romance,
            Action,
            ArtHouse,
            Indie,
        }
        public class Movie
        {
            public string Title { get; set; }
            public string Genre { get; set; }

            public Movie(string Title, string Category)
            {
                this.Title = Title;
                this.Genre = Category;
            }
        }
    }
}
