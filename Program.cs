using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Items.Add(input);
            }
            int[] swapping = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.FirstIndex = swapping[0];
            box.SecondIndex = swapping[1];

            Console.WriteLine(box);
        }
    }
}