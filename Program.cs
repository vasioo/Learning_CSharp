using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            char[,] matrix = new char[dimentions[0], dimentions[1]];

            bool rightToLeft = true;
            int indexOfLastSymbol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (rightToLeft)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[indexOfLastSymbol++];
                        if (indexOfLastSymbol==snake.Length)
                        {
                            indexOfLastSymbol = 0;
                        }
                    }
                    rightToLeft = false;
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[indexOfLastSymbol++];
                        if (indexOfLastSymbol == snake.Length)
                        {
                            indexOfLastSymbol = 0;
                        }
                    }
                    rightToLeft = true;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
