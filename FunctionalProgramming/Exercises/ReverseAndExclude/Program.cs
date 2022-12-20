using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = Console.ReadLine().
                Split().
                Reverse().
                Select(int.Parse).
                ToArray();
            int n = int.Parse(Console.ReadLine());
            
            Func<int, int, bool> isDiv = (x, y) => x % y != 0;
            List<int> stack = arrayOfNums.Where(x=>isDiv(x,n)).ToList();
            Console.WriteLine(String.Join(" ",stack));
        }
    }
}
