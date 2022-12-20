using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> listOfNums = Enumerable.Range(1,n).ToList();     
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            foreach (var numb in array)
            {
                predicates.Add(x => x % numb == 0);
            }
            foreach (var number in listOfNums)
            {
                bool isDivisible = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}
