using System;
using System.Linq;

namespace MatricesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            int diagonal1 = 0;
            int diagonal2 = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int colo = 0; colo < rowInput.Length; colo++)
                {
                    matrix[row, colo] = rowInput[colo];
                }
            }
            //diagonal 1
            int col = 0;
            for (int row = 0; row < n; row++)
            {       
                diagonal1 += matrix[row, col];
                col++;
            }
            //diagonal2
            col = 0;
            for (int row = n-1; row >= 0; row--)
            {
                diagonal2 += matrix[row, col];
                col++;
            }
            if (diagonal2>diagonal1)
            {
                Console.WriteLine(diagonal2-diagonal1);
            }
            else
            {
                Console.WriteLine(diagonal1-diagonal2);
            }
        }
    }
}
