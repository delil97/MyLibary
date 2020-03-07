using MyLibary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibary
{
    public class RemoveFutBooks
    {
        public void getRemoveFut()
        {
            using (var bookRem = new BookContext())
            {
                Console.WriteLine("Type the id of the book you would like to remove:");


                BooksToRead bReem = new BooksToRead()
                {
                    Id = Int32.Parse(Console.ReadLine())
                };
                bookRem.BooksToRead.Remove(bReem);
                Console.WriteLine("Press enter to save changes.");
                Console.ReadLine();
                bookRem.SaveChanges();
                Console.WriteLine("The book has been deleted from the database!");
            }
        }
    }
}
