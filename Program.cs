using System;
using System.Linq;

namespace CountUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> isStartingWithCapital = w => Char.IsUpper(w[0]);
            Console.WriteLine(String.Join("\n",words.Where(isStartingWithCapital)));
        }
    }
}