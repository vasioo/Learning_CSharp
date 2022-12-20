using System;
using System.Collections.Generic;
using System.Linq;
namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[fieldSize, fieldSize];
            int rowOfMiner = 0;
            int colOfMiner = 0;
            List<string> listOfMovements = Console.ReadLine().Split().ToList();
            int coal = 0;
            int endRow = 0;
            int endCol = 0;
            for (int row = 0; row < fieldSize; row++)
            {
                char[] rowInput = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col< fieldSize; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (matrix[row,col]=='c')
                    {
                        coal++;
                    }
                    if (matrix[row,col]=='e')
                    {
                        endRow = row;
                        endCol = col;
                    }
                    if (matrix[row, col] == 's')
                    {
                        rowOfMiner = row;
                        colOfMiner = col;
                    }
                }
            }
            Queue<string> queue = new Queue<string>(listOfMovements);
            string shouldIStop = "no";
            string result = "";
            for (int i = 0; i < listOfMovements.Count; i++)
            {    
                if (queue.Peek() == "up")
                {
                    if (rowOfMiner - 1 >= 0)
                    {
                        rowOfMiner -= 1;
                        if (matrix[rowOfMiner, colOfMiner] == 'c')
                        {
                            coal--;
                            matrix[rowOfMiner, colOfMiner] = '*';
                            if (coal == 0)
                            {
                                result=$"You collected all coals! ({rowOfMiner}, {colOfMiner})";
                                shouldIStop = "yes";
                            }
                        }
                        if (matrix[rowOfMiner, colOfMiner] == 'e')
                        {
                            result=$"Game over! ({rowOfMiner}, {colOfMiner})";
                            shouldIStop = "yes";
                        }
                    }
                }
                else if (queue.Peek() == "down")
                {
                    if (rowOfMiner + 1 < fieldSize)
                    {
                        rowOfMiner += 1;
                        if (matrix[rowOfMiner, colOfMiner] == 'c')
                        {
                            coal--;
                            matrix[rowOfMiner, colOfMiner] = '*';
                            if (coal == 0)
                            {
                                result = $"You collected all coals! ({rowOfMiner}, {colOfMiner})";
                                shouldIStop = "yes";
                            }
                        }
                        if (matrix[rowOfMiner, colOfMiner] == 'e')
                        {
                            result =$"Game over! ({rowOfMiner}, {colOfMiner})";
                            shouldIStop = "yes";
                        }
                    }
                }
                else if (queue.Peek() == "left")
                {
                    if (colOfMiner - 1 >= 0)
                    {
                        colOfMiner -= 1;
                        if (matrix[rowOfMiner, colOfMiner] == 'c')
                        {
                            coal--;
                            matrix[rowOfMiner, colOfMiner] = '*';
                            if (coal == 0)
                            {
                                result = $"You collected all coals! ({rowOfMiner}, {colOfMiner})";
                                shouldIStop = "yes";
                            }
                        }
                        if (matrix[rowOfMiner, colOfMiner] == 'e')
                        {
                            result = $"Game over! ({rowOfMiner}, {colOfMiner})";
                            shouldIStop = "yes";
                        }
                    }
                }
                else if (queue.Peek() == "right")
                {
                    if (colOfMiner + 1 < fieldSize)
                    {
                        colOfMiner += 1;
                        if (matrix[rowOfMiner, colOfMiner] == 'c')
                        {
                            coal--;
                            matrix[rowOfMiner, colOfMiner] = '*';
                            if (coal == 0)
                            {
                                result = $"You collected all coals! ({rowOfMiner}, {colOfMiner})";
                                shouldIStop = "yes";
                            }
                        }
                        if (matrix[rowOfMiner, colOfMiner] == 'e')
                        {
                            result = $"Game over! ({rowOfMiner}, {colOfMiner})";
                            shouldIStop = "yes";
                        }
                    }
                }
                if (shouldIStop=="yes")
                {
                    break;
                }
                queue.Dequeue();
                
            }
            if (shouldIStop == "no")
            {
                Console.WriteLine($"{coal} coals left. ({rowOfMiner}, {colOfMiner})");
            }
            if (shouldIStop=="yes")
            {
                Console.WriteLine(result);
            }
        }
    }
}
