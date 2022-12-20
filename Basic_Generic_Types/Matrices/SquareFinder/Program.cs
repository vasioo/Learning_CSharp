using System;
using System.Linq;

namespace _1._2X2_SquareFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] whole = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = whole[0];
            int cols = whole[1];
            int[,] matrix = new int[rows, cols];
            int counterOfFound = 0;
            for (int row = 0; row < rows; row++)
            {
                char[] rowInput = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int colo = 0; colo <cols; colo++)
                {
                    matrix[row, colo] = rowInput[colo];
                }
            }
            for (int row = 0; row < rows-1; row++)
            {
                for (int col= 0; col < cols-1; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1]
                     && matrix[row+1, col] == matrix[row + 1, col + 1])
                    {
                        counterOfFound++;
                    }
                }
            }
            Console.WriteLine(counterOfFound);
        }
    }
}
