using System.Collections;
using System.Collections.Generic;

namespace LibraryIterator
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(List<Book> books)
        {
            this.books = books;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}