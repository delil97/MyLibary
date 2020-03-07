using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibary.Models
{
    public class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("1) Add a new book that you would like to read in the future");
            Console.WriteLine("2) Add a book that you completed");
            Console.WriteLine("3) Show all the books you would like to read in the future");
            Console.WriteLine("4) Show all the books you completed");
            Console.WriteLine("5) Delete a completed book");
            Console.WriteLine("6) Delete a future book");
            Console.SetCursorPosition(0, 8);

            Console.Write("Please choose a number from above: ");
        }
    }
}
