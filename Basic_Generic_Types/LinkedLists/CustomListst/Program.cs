using System;
using System.Collections.Generic;

namespace CustomLists
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList customList = new CustomList();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Shrink();
            int element = customList.RemoveAt(2);
            Console.WriteLine(element);
            Console.WriteLine(customList.Count);
            customList.Contains(5);
            customList.Swap(0, 1);
        }
    }
}
