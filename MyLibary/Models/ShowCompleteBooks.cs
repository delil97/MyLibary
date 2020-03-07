using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibary.Models
{
   public class ShowCompleteBooks
    {
        public void CompletedBooks()
        {
            using (var bookCShow = new BookContext())
            {
                foreach (var item in bookCShow.CurrentBooks.ToList())
                {
                    Console.WriteLine("Id: " + item.Id + "\n"
                        + " Book Name: " + item.BookName + "\n" + " Book Author: "
                        + item.BookAuthor + "\n" + " Book Sumary: " + item.BookSumary);
                }
            }
        }
    }
}
