using System;
using System.Collections.Generic;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> saver = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] people = Console.ReadLine().Split(", ");
                saver.Add(people[0],Convert.ToInt32(people[1]));
            }
            string command = Console.ReadLine();
            int checker = 0;
            if (command=="older")
            {
                checker = int.Parse(Console.ReadLine());
                string whatToPrint = Console.ReadLine();
                foreach (var item in saver)
                {
                    if (item.Value>=checker)
                    {
                        if (whatToPrint=="name")
                        {
                            Console.WriteLine($"{item.Key}");
                        }
                        if (whatToPrint == "age")
                        {
                            Console.WriteLine($"{item.Value}");
                        }
                        if (whatToPrint == "name age")
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
            if (command=="younger")
            {
                checker = int.Parse(Console.ReadLine());
                string whatToPrint = Console.ReadLine();
                foreach (var item in saver)
                {
                    if (item.Value < checker)
                    {    
                        if (whatToPrint == "name")
                        {
                            Console.WriteLine($"{item.Key}");
                        }
                        if (whatToPrint == "age")
                        {
                            Console.WriteLine($"{item.Value}");
                        }
                        if (whatToPrint == "name age")
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
