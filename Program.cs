using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"D:\Stream Files And Directories ex\Stream Files And Directories ex\text.txt"))
            {
                int index = 0;
                string lines = reader.ReadLine();
                    int counter = 0;
                    int signs =1;
                
                foreach (string line in System.IO.File.ReadLines(@"D:\Stream Files And Directories ex\Stream Files And Directories ex\text.txt"))
                {
                    index++;
                    foreach (var item in line)
                    {
                        if ((item >= 'a' && item <= 'z') || (item >= 'A' && item <= 'Z'))
                        {
                            counter++;
                        }
                        else if (item >= '0' && item <= '9')
                        {
                            counter++;
                        }
                        else
                        {
                            if (item != ' ')
                            {
                                signs++;
                            }
                        }
                    }
                    Console.WriteLine($"Line {index}: {lines} ({counter})({signs})");
                    counter = 0;
                    signs = 0;
                }
            }
        }
    }
}
