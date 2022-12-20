using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string,bool> funct = (name)
                => name.Length <=n;
            string[] result = names.Where(x => funct(x)).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, result)); 
        }
    }
}
