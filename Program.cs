using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getMin = nums=>
            {
                int minimum = int.MaxValue;
                foreach (var item in nums)
                {
                    if (item<minimum)
                    {
                        minimum = item;
                    }
                }
                return minimum;
            };

            int[] arrayOfNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(getMin(arrayOfNums));
        }
    }
}
