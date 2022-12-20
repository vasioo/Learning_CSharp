using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("../../../CoolDir");
            Directory.Move("../../../CoolDir", "../../../bin/CollDir2");
            Directory.Delete("../../../bin/CollDir2");
        }
    }
}
