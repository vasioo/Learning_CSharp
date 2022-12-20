using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int biggestOrder = 0;
            int itemMore = 0;
            Queue<int> queue = new Queue<int>(orders);
            //biggestOrder
                List<int> temp = new List<int>();
                foreach (var item in queue)
                {
                    temp.Add(item);
                }
                biggestOrder = temp[0];
                for (int j = 0; j < temp.Count; j++)
                {
                    if (temp[j] >= biggestOrder)
                    {
                        biggestOrder = temp[j];             
                    }
                }
                Console.WriteLine(biggestOrder);
            //Function
            int sum = 0;
            bool isItEmpty = true;
            foreach (var item in temp)
            {
                if (sum < quantity)
                {
                    sum += item;
                    if (sum > quantity)
                    {
                        sum -= item;
                        itemMore += item;
                        isItEmpty = true;
                        break;
                    }
                    else if (sum <= quantity)
                    {
                        isItEmpty = false;
                    }
                }

            }
            if (isItEmpty==false)
            {
                Console.WriteLine("Orders complete");
            }
            else if (isItEmpty == true)
            {
                Console.WriteLine("Orders left: " + itemMore);
            }
        }
    }
}
