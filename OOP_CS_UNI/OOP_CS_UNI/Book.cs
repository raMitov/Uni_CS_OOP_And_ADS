using System;

namespace OOP_CS_UNI
{
    public class Book
    {
        protected string title;
        protected string author;
        protected string pageCount;
        protected string price;

        public Book()
        {
            
        }
        public Book(string title, string author, string pageCount, string price)
        {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.price = price;
        }

        public void getInfo()
        {
            Console.WriteLine($"{title} - {author} - {pageCount} pages - {price} LV");
        }
    }
}