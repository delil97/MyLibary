using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibary.Models
{
    public class AddFuturBooks
    {

        public void AddFutureBooks()
        {
            using (var bookF = new BookContext())
            {
                Console.WriteLine("Add a new book, BookName, BookAuthor and sumary");
                BooksToRead b = new BooksToRead()
                {

                    BookName = Console.ReadLine(),
                    BookAuthor = Console.ReadLine(),
                    BookSumary = Console.ReadLine()
                };


                bookF.BooksToRead.Add(b);
                Console.WriteLine("Press enter to save changes.");
                Console.ReadLine();
                bookF.SaveChanges();
                Console.WriteLine("The book has been saved in the database!");

            }

        }

    }
}
