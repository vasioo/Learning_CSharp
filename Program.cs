using System;
using System.IO;

namespace BaseStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream stream = new MemoryStream();
            byte[] buffer = new byte[] { 1, 2, 3, 4, 5 };
            stream.Write(buffer, 0, buffer.Length);
            byte[] read = new byte[buffer.Length];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(read, 0,(int) stream.Length);

            Console.WriteLine(String.Join(" ",read));
        }
    }
}
