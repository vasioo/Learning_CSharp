using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            HashSet<double> set = new HashSet<double>();
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                var check = double.Parse(Console.ReadLine());
                if (set.Contains(check))
                {
                    list.Add(check);
                    list.Add(check);
                }
                else
                {
                    set.Add(check);
                }
            }
            List<double> temp = new List<double>(); 
            for (int i = 0; i < list.Count; i++)
            {
                int counter = 1;
                for (int z = i+1; z < list.Count; z++)
                {
                    if (list[i]==list[z])
                    {
                        counter++;
                    }
                }
                if (counter%2==0)
                {
                    temp.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join(" ",temp));
        }
    }
}
