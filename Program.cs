using System;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[],string> printKnights = (name,title)
                => Console.WriteLine(
                    title+String.Join(Environment.NewLine+title,name));
            string[] knightNames = Console.ReadLine().Split();
            printKnights(knightNames,"Sir ");
        }
    }
}
