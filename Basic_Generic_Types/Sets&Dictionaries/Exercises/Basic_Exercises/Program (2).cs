using System;
using System.Collections.Generic;

namespace uniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (double i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
