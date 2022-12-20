using System;
using System.Linq;

namespace SubmatrixInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestSquareRows = 3  ;
            int biggestSquareCols = 2;

            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row+biggestSquareRows-1<rows&&col+biggestSquareCols-1<cols)
                    {
                        int sum = 0;
                        for (int currentRow = row; currentRow < row+biggestSquareRows; currentRow++)
                        {
                            for (int currentCol = col; currentCol < col+biggestSquareCols; currentCol++)
                            {
                                sum += matrix[currentRow, currentCol];
                            }
                        }
                        if (sum>maxSum)
                        {
                            maxSum = sum;
                            maxColIndex = col;
                            maxRowIndex = row;
                        }
                    }
                }
            }
            for (int row = maxRowIndex; row < maxRowIndex+biggestSquareRows; row++)
            {
                for (int col = maxColIndex; col < maxColIndex+biggestSquareCols; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
