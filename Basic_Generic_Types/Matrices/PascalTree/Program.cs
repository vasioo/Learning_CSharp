using System;

namespace PascalTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] pascalTriangle = new int[n][];
            pascalTriangle[0] = new int[1] { 1 };
            for (int row = 1; row < n; row++)
            {
                pascalTriangle[row] = new int[pascalTriangle[row - 1].Length+1];
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (pascalTriangle[row-1].Length>col)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col];
                        
                    }
                    if (col>0)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col - 1];
                    }
                }
            }
            PrintJagged(pascalTriangle);
        }
        static void PrintJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine($"{String.Join(" ", jagged[row])}");
            }
        }
    }
}
