using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Stream_Files_And_Directories_ex
{
    class Program
    {
        static void Main(string[] args)
        {
           using (StreamReader reader = new StreamReader(@"D:\Stream Files And Directories ex\Stream Files And Directories ex\text.txt"))
            {
                //reversing the Array
                string text =reader.ReadToEnd();
                text = text.Replace('-', '@');
                text = text.Replace(',', '@');
                text = text.Replace('.', '@');
                text = text.Replace('!', '@');
                text = text.Replace('?', '@');
                string[] newArray = text.Split();
                Stack<string> listInOrder = new Stack<string>();
                foreach (var item in newArray)
                {
                    listInOrder.Push(item);
                }
                Console.WriteLine(String.Join(" ", listInOrder));
            }
        }
    }
}
