using System;
using System.Linq;
using System.Collections.Generic;

namespace Add_Vat
{
    class Program
    {
        static void Main(string[] args)
        {
            
           List<decimal> prices = Console.ReadLine().Split(", ").Select(decimal.Parse).ToList();
            Func<decimal, decimal> vatAdder = x => x + x * 0.2m;
            prices = prices.Select(vatAdder).ToList();
            prices.ForEach(n => Console.WriteLine($"{n:f2}"));

        }
    }
}
