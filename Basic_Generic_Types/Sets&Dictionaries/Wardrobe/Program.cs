using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> clothes = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split("-> ").ToList();
                if (clothes.ContainsKey(input[0]))
                {
                    clothes[input[0]].Add(input[1]);
                }
                else
                {
                    clothes.Add(input[0], new List<string>());
                    List<string> items = new List<string>();
                    string[] main= input[1].Split(",");
                    foreach (var item in main)
                    {
                        clothes[input[0]].Add(item);
                    }
                }
            }
            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var element in item.Value)
                {
                    Console.WriteLine($"* {element}");
                }
            }
        }
    }
}
