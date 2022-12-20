using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothesInTheBox);
            int capacity = int.Parse(Console.ReadLine());
            int numberOfRacks = 1;
            int sum = 0;
            int counter = 0;
            foreach (var item in stack)
            {
                counter++;
                int temp = sum;
                sum = 0;
                sum = sum + item;
                for (int i = 0; i <= (stack.Count - counter); i++)
                {
                    sum += clothesInTheBox[i];
                }
                if (sum <= capacity)
                {
                    numberOfRacks++;
                    break;
                }
                sum = 0;
                sum = temp;
                temp = 0;
                if (sum + item < capacity)
                {
                    sum += item;
                }
                else if (sum+item==capacity)
                {
                    numberOfRacks++;
                    sum = 0;
                }
                else
                {
                    numberOfRacks++;
                    sum = item;        
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
