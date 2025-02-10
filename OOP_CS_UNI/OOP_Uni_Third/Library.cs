using System;
using System.Collections.Generic;

namespace OOP_Uni_Third
{
    public class Library
    {
        public List<Book> Books = new List<Book>();
        public List<string> History = new List<string>();

        

        public void InitializeBooks()
        {
            Console.WriteLine("Initialize books");
            while (true)
            {
                Console.WriteLine("If you want to exit press 1");
                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    break;
                }
                Console.WriteLine("Enter book name:");
                string nameOfBook = Console.ReadLine();
                Console.WriteLine("Enter book author:");
                string authorOfBook = Console.ReadLine();
                Console.WriteLine("Enter book number:");
                string uniqueNumOfBook = Console.ReadLine();
                Book newBook = new Book(nameOfBook, authorOfBook, uniqueNumOfBook);
                Books.Add(newBook);
            }
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}