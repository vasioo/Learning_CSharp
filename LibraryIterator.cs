using System.Collections;
using System.Collections.Generic;

namespace LibraryIterator
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int index;
        public LibraryIterator(List<Book> books)
        {
            this.books = books;
            index = -1;
        }
        public Book Current => books[index];

        public bool MoveNext()
        {
            index++;
            return index < books.Count;
        }
        public void Reset(){}
        public void Dispose(){}
        object IEnumerator.Current => Current;
    }
}
