﻿using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[array[0], array[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int maxSum = 0;
            int currentSum = 0;
            int[,] maxSumMatrix = new int[3, 3];
            int[] maxColRow = new int[2];
            for (int row = 1; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                {
                    if (currentSum <= maxSum)
                    {
                        currentSum = matrix[row - 1, col - 1] + matrix[row, col - 1] + matrix[row + 1, col - 1] + matrix[row - 1, col] + matrix[row, col] + matrix[row + 1, col] + matrix[row - 1, col + 1] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    }
                    else
                    {
                        maxSum = currentSum;
                        maxColRow[0] = row;
                        maxColRow[1] = col;
                        currentSum = 0;
                    }
                }
            }
            maxSumMatrix[0, 0] = matrix[maxColRow[0] - 1, maxColRow[1] - 1 - 1];
            maxSumMatrix[0, 1] = matrix[maxColRow[0], maxColRow[1] - 1 - 1];
            maxSumMatrix[0, 2] = matrix[maxColRow[0] + 1, maxColRow[1] - 1 - 1];
            maxSumMatrix[1, 0] = matrix[maxColRow[0] - 1, maxColRow[1] - 1];
            maxSumMatrix[1, 1] = matrix[maxColRow[0], maxColRow[1] - 1];
            maxSumMatrix[1, 2] = matrix[maxColRow[0] + 1, maxColRow[1] - 1];
            maxSumMatrix[2, 0] = matrix[maxColRow[0] - 1, maxColRow[1] + 1 - 1 ];
            maxSumMatrix[2, 1] = matrix[maxColRow[0], maxColRow[1] + 1 -1 ];
            maxSumMatrix[2, 2] = matrix[maxColRow[0] + 1, maxColRow[1] + 1 -1 ];
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < maxSumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maxSumMatrix.GetLength(1); col++)
                {
                    Console.Write(maxSumMatrix[col,row] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
