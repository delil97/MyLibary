using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibary.Models

{
    public class BooksToRead
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookSumary { get; set; }

        public List<CurrentBooks> CurrentBooks { get; } = new List<CurrentBooks>();
    }

    public class CurrentBooks
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookSumary { get; set; }

    }
}
