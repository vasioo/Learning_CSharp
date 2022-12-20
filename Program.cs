using System;
using System.Collections.Generic;
namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(5);  
            set.Add(2);  
            set.Add(3);  
            set.Add(1);  
            set.Add(52);

            Console.WriteLine(set.Contains(2));
        }
    }
}
