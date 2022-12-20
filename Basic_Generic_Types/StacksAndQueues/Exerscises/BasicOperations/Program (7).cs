using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] PushPopFind = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //number of elments into the stack
            int N = PushPopFind[0];
            //number of elements to pop from the stack
            int S = PushPopFind[1];
            //which element to search for
            int X = PushPopFind[2];
            string IsItPresent = "";
            int[] elementsToBePushed = new int[N];
            elementsToBePushed = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> stack = new Queue<int>();
            List<int> list = new List<int>();
            foreach (var item in elementsToBePushed)
            {
                stack.Enqueue(item);
            }
            for (int i = 0; i < S; i++)
            {
                stack.Dequeue();
            }
            foreach (var item in stack)
            {
                if (item == X)
                {
                    IsItPresent = "true";
                    break;
                }
            }
            if (IsItPresent != "true")
            {
                int smallestNumber = 0;
                if (stack.Count == 0)
                {
                    smallestNumber = 0;
                }
                else
                {
                    foreach (var item in stack)
                    {

                        list.Add(item);
                    }
                    smallestNumber = list[0];
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= smallestNumber)
                        {
                            smallestNumber = list[i];
                        }
                    }
                }
                IsItPresent = $"{smallestNumber}";
            }
            Console.WriteLine(IsItPresent);
        }
    }
}
