using System;
using System.Linq;

namespace MatrixShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] whole = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[whole[0], whole[1]];
            //chetem
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowInput = Console.ReadLine().Split().ToArray();
                for (int colo = 0; colo < rowInput.Length; colo++)
                {
                    matrix[row, colo] = rowInput[colo];
                }
            }
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0]!="END")
            {
                command = Console.ReadLine().Split().ToArray();
                if (command[0]=="swap"&&command.Length==5)
                {
                    string temp = matrix[Convert.ToInt32(command[1]), Convert.ToInt32(command[2])];
                    matrix[Convert.ToInt32(command[1]),Convert.ToInt32(command[2])]
                        =matrix[Convert.ToInt32(command[3]), Convert.ToInt32(command[4])];

                    matrix[Convert.ToInt32(command[3]), Convert.ToInt32(command[4])]
                        = temp;

                    for (int row = 0; row <whole[0] ; row++)
                    {
                        for (int col = 0; col < whole[1]; col++)
                        {
                            Console.Write(matrix[row,col]+" ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
