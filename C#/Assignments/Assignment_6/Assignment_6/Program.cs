using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
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
                Console.WriteLine("Book: " + BookName + ", Author: " + AuthorName);
            }
        }
        class BookShelf
        {
            private Books[] books = new Books[5]; 
            public Books this[int index]
            {
                get { return books[index]; }
                set { books[index] = value; }
            }
        }

        static void Main(string[] args)
        {

            BookShelf shelf = new BookShelf();

            shelf[0] = new Books("C# Basics", "John");
            shelf[1] = new Books("OOP Concepts", "Smith");
            shelf[2] = new Books("Data Structures", "David");
            shelf[3] = new Books("Algorithms", "Alice");
            shelf[4] = new Books("DotNet Guide", "Robert");

            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }
        }
    }
}
