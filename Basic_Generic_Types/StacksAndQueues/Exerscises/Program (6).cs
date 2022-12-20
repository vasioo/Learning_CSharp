using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            List<string> result = new List<string>();
            for (int i = 0; i < N; i++)
            {
                int smallestNumber = 0;
                int biggestNumber = 0;
                List<int> temp = new List<int>();
                List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
                int command =list[0];
                if (command==1)
                {
                    int element = list[1];
                    stack.Push(element);
                }
                if (command == 2&& stack.Count>0)
                {
                    stack.Pop();
                }
                if (command == 3)
                {
                    if (stack.Count == 0)
                    {
                        return;
                    }
                    else
                    {
                        foreach (var item in stack)
                        {
                            temp.Add(item);
                        }
                        biggestNumber = temp[0];
                        for (int j = 0; j < temp.Count; j++)
                        {
                            if (temp[j] >= biggestNumber)
                            {
                                biggestNumber = temp[j];
                            }
                        }
                       result.Add(biggestNumber.ToString());
                    }
                }
                if (command == 4)
                {
                    if (stack.Count == 0)
                    {
                        return;
                    }
                    else
                    {
                        foreach (var item in stack)
                        {
                            temp.Add(item);
                        }
                        smallestNumber = temp[0];
                        for (int j = 0; j < temp.Count; j++)
                        {
                            if (temp[j] <= smallestNumber)
                            {
                                smallestNumber = temp[j];
                            }
                        }
                        result.Add(smallestNumber.ToString());
                    }
                }

            }
            string resu = "";
            foreach (var item in stack)
            {
                 resu +=(item+", ");
            }
            resu =resu.TrimEnd(' ');
            result.Add(resu.TrimEnd(','));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
