using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rowCount = sizes[0];
            int columnCount = sizes[1];

            int[,] matrix = new int[rowCount, columnCount];

            for (int row = 0; row < rowCount; row++)
            {
                int[] currentRow = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < columnCount; col++)
                {
                    matrix[row, col] = currentRow[col];
                }

            }

            int maxSum = int.MinValue;
            int targetRow = 0;
            int targetCol = 0;

            for (int r = 0; r < rowCount - 2; r++)
            {
                for (int c = 0; c < columnCount - 2; c++)
                {
                    int currentsum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                        matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                        matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (currentsum > maxSum)
                    {
                        maxSum = currentsum;
                        targetRow = r;
                        targetCol = c;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);

            for (int row = targetRow; row <= targetRow + 2; row++)
            {
                for (int col = targetCol; col <= targetCol + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }

        }
    }
}
