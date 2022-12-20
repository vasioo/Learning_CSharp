using System;
using System.IO;
namespace ReadOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
              Console.WriteLine("Hey hey");
                using (StreamReader reader = new StreamReader(@"directory"))
                {
                    int index = 0;
                    var line = reader.ReadLine();
                    while (line!=null)
                    {
                        writer.WriteLine($"{index + 1}. {line}");
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
