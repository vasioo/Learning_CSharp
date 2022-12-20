using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensAndOds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string oddEven = Console.ReadLine();
            List<int> numbers = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> isEven = x
                 => x % 2 == 0;
            Predicate<int> isOdd = x
                => x % 2 == 1;
            List<int> result;
            if (oddEven=="odd")
            {
                result = numbers.FindAll(isOdd);
            }
            else if (oddEven=="even")
            {
                result = numbers.FindAll(isEven);
            }
            else
            {
                result = null;
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
