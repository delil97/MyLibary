using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibary.Models
{
  public class AddCompletBooks
    {
        public  void AddCompleteBooks()
        {
            using (var bookC = new BookContext())
            {
                Console.WriteLine("Add the book you just finished by typing: BookName, BookAuthor and sumary");
                CurrentBooks b = new CurrentBooks()
                {

                    BookName = Console.ReadLine(),
                    BookAuthor = Console.ReadLine(),
                    BookSumary = Console.ReadLine()
                };

                bookC.CurrentBooks.Add(b);
                Console.WriteLine("Press enter to save changes.");
                Console.ReadLine();
                bookC.SaveChanges();
                Console.WriteLine("The book has been saved in the database!");

            }
        }

    }
}
