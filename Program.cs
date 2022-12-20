using System;
using System.IO;

namespace Infos
{
    class Program
    {
        public static long ReadDirectory(string path,int indent)
        {
            long byteLenght = 0;
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            Console.WriteLine($"{new string(' ', indent * 3)} {dirInfo.Name}");

            string[] subDirs = Directory.GetDirectories(path);
            foreach (var subDir in subDirs)
            {
                byteLenght+=ReadDirectory(subDir,indent+1);
            }
            foreach (var file in files)
            {
                Console.WriteLine($"{new string(' ',(indent+1)*3)} {file.Name}");
                byteLenght += file.Length;
            }
            return byteLenght;
        }
        static void Main(string[] args)
        {
            var dirPath = Console.ReadLine();
            ReadDirectory(dirPath,0);

            Console.WriteLine($"Size in kbytes: {ReadDirectory(dirPath,0)/1024}");
        }
    }
}
