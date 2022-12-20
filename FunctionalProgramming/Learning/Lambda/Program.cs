using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers= numbers.Where(x => x > 3).ToList();
            //edno i sushto e
            //numbers= numbers.Where(IsBigger).ToList();
            //numbers= numbers.Select(Multiply).ToList();
            numbers= numbers.Where(x=> { return x > 3; }).ToList();
            Console.WriteLine(String.Join(",",numbers));
        }
        public static bool IsBigger(int x) 
        {
            return x > 3;
        }
        public static int Multiply(int x)
        {
            return x * 5;
        }
    }
}
