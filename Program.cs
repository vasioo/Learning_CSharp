using System;
using System.Linq;
using System.Collections.Generic;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Action<int[]> add = x 
                => nums = x.Select(x => x + 1).ToArray();
            Action<int[]> subtract = x 
                => nums = x.Select(x => x - 1).ToArray();
            Action<int[]> multiply = x 
                => nums = x.Select(x => x * 2).ToArray();
            Action<int[]> print = x 
                => Console.WriteLine(String.Join(" ",x));
            while (command!="end")
            {
                if (command=="add")
                {
                     add(nums);
                }
                else if (command == "multiply")
                {
                    multiply(nums);
                }
                else if (command == "subtract")
                {
                    subtract(nums);
                }
                else if (command == "print")
                {
                    print(nums);
                }
                command = Console.ReadLine();
            }
        }
    }
}
