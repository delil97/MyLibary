using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibary.Models
{
    public class ShowFutureBooks
    {

        public void FutureBooks()
        {
            using (var bookShow = new BookContext())
            {
                foreach (var item in bookShow.BooksToRead.ToList())
                {
                    Console.WriteLine("Id: " + item.Id + "\n"
                        + " Book Name: " + item.BookName + "\n" + " Book Author: "
                        + item.BookAuthor + "\n" + " Book Sumary: " + item.BookSumary);
                }
            }
        }
    }
}
