using System;
using System.Collections.Generic;

namespace _PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();
            for (double i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    chemicalElements.Add(item);
                }
            }
            Console.WriteLine(String.Join(" ",chemicalElements));
        }
    }
}
