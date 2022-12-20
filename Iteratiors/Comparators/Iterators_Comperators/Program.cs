using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Peshko";
            person.LastName = "Peshkov";
            foreach (var item in person)
            {
                Console.WriteLine(item);
            }
            //IEnumerator<int> enumerator = person.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var item = enumerator.Current;
            //    Console.WriteLine(item);
            //}
        }
    }
    class Person : IEnumerable<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Grades { get; set; } = new List<int> { 4, 5, 6 };

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = Grades.Count - 1; i >= 0; i--)
            {
                yield return Grades[i];
            }
            //return Grades.GetEnumerator();
            //return new ReversePersonGradesEnumeratr(Grades);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class ReversePersonGradesEnumeratr : IEnumerator<int>
    {
        private int index;
        private List<int> items;
        public int Current => items[index];
        public ReversePersonGradesEnumeratr(List<int> items)
        {
            this.items = items;
            index = items.Count;
        }
        public bool MoveNext()
        {
            index--;
            if (index < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Reset() { }
        public void Dispose() { }
        object IEnumerator.Current => this.Current;
    }
}
