using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LibraryIterator
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result==0)
            {
                return this.Year.CompareTo(other.Year);
            }
            return result;
        }
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
