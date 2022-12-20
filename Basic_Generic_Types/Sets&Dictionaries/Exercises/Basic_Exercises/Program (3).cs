using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorted Dictionary
            SortedDictionary<double,string> studentNumbers = new SortedDictionary<double, string>();
            studentNumbers.Add(13, "Pesho");
            studentNumbers.Add(12, "Bobi");
            studentNumbers.Add(3, "Gogi");
            studentNumbers.Add(24, "Ivan");
            foreach (var item in studentNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
