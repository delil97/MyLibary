using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLibary.Models
{
    class RemoveCompBooks
    {
       
        public void getRemove()
        {
            using (var bookRem = new BookContext())
            {
              
                Console.WriteLine("Type the id of the book you would like to remove:");
                CurrentBooks bRem = new CurrentBooks() { 
                    Id = Int32.Parse(Console.ReadLine())
                };
                bookRem.CurrentBooks.Remove(bRem);
                Console.WriteLine("Press enter to save changes.");
                Console.ReadLine();
                bookRem.SaveChanges();
                Console.WriteLine("The book has been deleted from the database!");


            }
        }

    }
}
