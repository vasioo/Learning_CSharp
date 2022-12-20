using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            HashSet<double> set1 = new HashSet<double>((int)array[0]);
            HashSet<double> set2= new HashSet<double>((int)array[1]);
            HashSet<double> combiningSet= new HashSet<double>();
            for (double i = 0; i <array[0]; i++)
            {
                set1.Add(double.Parse(Console.ReadLine()));
            }
            for (double i = 0; i < array[1]; i++)
            {
                set2.Add(double.Parse(Console.ReadLine()));
            }
            foreach (var item in set2)
            {
                if (set1.Contains(item))
                {
                    combiningSet.Add(item);
                }
            }
            Console.WriteLine(String.Join(" ",combiningSet));
        }
    }
}
