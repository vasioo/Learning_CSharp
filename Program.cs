using System;
using System.Collections.Generic;
using System.Linq;

namespace VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split().ToList();
            var vloggerName = command[0];
            HashSet<string> set = new HashSet<string>();
            if (command[1]=="joined")
            {
                set.Add(command[0]);
            }
        }
    }
}
