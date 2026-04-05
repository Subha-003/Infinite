using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{

    class Books
    {
        public string BookName;
        public string AuthorName;

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book: {BookName}, Author: {AuthorName}");
        }
    }
    class BookShelf
    {
        private Books[] bookList = new Books[5];

        public Books this[int index]
        {
            get { return bookList[index]; }
            set { bookList[index] = value; }
        }
    }

    internal class indexer
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf();

            shelf[0] = new Books("C#", "Microsoft");
            shelf[1] = new Books("Java", "James Gosling");
            shelf[2] = new Books("Python", "Guido");
            shelf[3] = new Books("C++", "Bjarne");
            shelf[4] = new Books("SQL", "Oracle");

            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }
        }
    }
}
