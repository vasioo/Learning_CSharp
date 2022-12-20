using System;
using System.Collections.Generic;

namespace Action1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };

            Iterate(list, x => Console.WriteLine(x));
        }
        public static void Iterate(List<int> list, Action<int> callback)
        {
            foreach (var item in list)
            {
                callback(item);
            }
        }
    }
}
