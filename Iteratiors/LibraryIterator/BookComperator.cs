using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryIterator
{
    public class BookComperator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int result = x.Title.CompareTo(y.Title);
            if (result==0)
            {
                return x.Year.CompareTo(y.Year);
            }
            return result;
        }
    }
}
