using System;
using System.Collections.Generic;
using System.Linq;

namespace CountItems
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, double> numberOfOccurences = new Dictionary<double, double>();
            foreach (var number in numbers)
            {
                if (!numberOfOccurences.ContainsKey(number))
                {
                    numberOfOccurences.Add(number, 0);
                }
                numberOfOccurences[number]++;
            }
            foreach (var item in numberOfOccurences)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
