using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(bullets);
            Queue<int> queue = new Queue<int>(locks);
            int counter = 0;
            while (true)
            {
                for (int i = 0; i < sizeOfGunBarrel; i++)
                {
                    if (stack.Count > 0 && queue.Count > 0 && stack.Peek() > queue.Peek())
                    {
                        stack.Pop();
                        Console.WriteLine("Ping!");
                        counter++;
                    }
                    else if (stack.Count > 0 && queue.Count > 0&&stack.Peek() <= queue.Peek())
                    {
                        stack.Pop();
                        queue.Dequeue();
                        Console.WriteLine("Bang!");
                        counter++;
                    }
                }
                if (queue.Count == 0)
                {
                    if (stack.Count!=0)
                    {
                        Console.WriteLine("Reloading!");
                    }
                    Console.WriteLine($"{stack.Count} bullets left. Earned ${valueOfIntelligence - (priceOfBullet * counter)}");
                    break;
                }
                if (stack.Count == 0)
                {
                    Console.WriteLine("Couldn't get through. Locks left: " + queue.Count);
                    break;
                }
                Console.WriteLine("Reloading!");
            }
        }
    }
}