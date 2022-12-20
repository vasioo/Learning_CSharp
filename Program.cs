using System;
using System.Collections.Generic;

namespace LibraryIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book()
            {
                Title = "Aaa",
                Year = 1900,
                Authors = new List<string> { "A" }
            });
            books.Add(new Book()
            {
                Title = "Bbb",
                Year = 2000,
                Authors = new List<string> { "B", "C" }
            });
            books.Add(new Book()
            {
                Title = "Ccc",
                Year = 3000,
                Authors = new List<string> { "A", "B", "C" }
            });
            books.Sort(new BookComperator());
            Library library = new Library(books);
            foreach (Book book in library)
            {
                Console.WriteLine($"{book.Title} ---- {book.Year}");
            }
        }
    }
}
