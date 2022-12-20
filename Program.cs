using System;
using System.IO;
using System.Text;

namespace FStreans
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Pehso";
            //using (FileStream stream = new FileStream("text.txt",FileMode.OpenOrCreate))
            //{
            //    Console.WriteLine(stream.Length);
            //    stream.Seek(stream.Length, SeekOrigin.Begin);
            //    byte[] data =Encoding.UTF8.GetBytes(text);
            //    Console.WriteLine($"{String.Join(",",data)}");
            //    stream.Write(data,0,data.Length);
            //}
            using (FileStream stream = new FileStream("text.txt", FileMode.OpenOrCreate))
            {
                byte[] data = new byte[5];
                while (stream.Read(data,0,data.Length)>0)
                {
                    stream.Read(data, 0, data.Length);
                    string text = Encoding.UTF8.GetString(data);
                    Console.WriteLine(String.Join(" ", data));
                    data= new byte[5];
                }
            }
        }
    }
}
