using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y= int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            GetMethod(sign);
            Func<int, int, int> calc = GetMethod(sign);
            Console.WriteLine(calc(x,y));
          
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int Substract(int x, int y)
        {
            return x - y;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static Func<int,int,int> GetMethod(string input)
        {
            switch (input)
            {
                case "*": return Multiply;
                case "+":
                    return Sum;
                case "-":
                    return Substract;
                default:
                    return null;
            }
        }
    }
}
