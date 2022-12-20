using System;
using System.IO;

namespace Streams_Files_And_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader
                (@"directory"))
            {
                string textFromFile = reader.ReadToEnd();
                Console.WriteLine(textFromFile);
            }
        }
    }
}
