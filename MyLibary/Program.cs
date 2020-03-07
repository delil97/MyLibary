using MyLibary.Models;
using System;
using System.Linq;

namespace MyLibary
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling all necesary methods from the classes
            AddFuturBooks bookF = new AddFuturBooks();
            AddCompletBooks bookC = new AddCompletBooks();
            ShowFutureBooks bookShow = new ShowFutureBooks();
            ShowCompleteBooks bookCShow = new ShowCompleteBooks();
            RemoveCompBooks bookR = new RemoveCompBooks();
            RemoveFutBooks bookRF = new RemoveFutBooks();


            Menu ShowMenu = new Menu();
            bool listRunning = true;
            while (listRunning)
            {

                char ch;
                ShowMenu.ShowMenu();
            
                ch = char.Parse(Console.ReadLine());

                switch (ch)
                {

                    case '1':
                        bookF.AddFutureBooks(); // caliing methods from the class AddFBooks
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case '2':
                        bookC.AddCompleteBooks();
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case '3':
                        bookShow.FutureBooks();
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case '4':
                        bookCShow.CompletedBooks();
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    

                    case '5':
                        bookCShow.CompletedBooks();
                        bookR.getRemove();
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case '6':
                        bookShow.FutureBooks();
                        bookRF.getRemoveFut();
                        Console.WriteLine("Press [ENTER] to go back to the menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
