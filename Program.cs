using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace PrintingNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> printNames = name
                => Console.WriteLine(
                    string.Join(Environment.NewLine,name));
            printNames(names);
        }
    }
}
