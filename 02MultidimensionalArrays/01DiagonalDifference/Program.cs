using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }

                Console.WriteLine();
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

           
            int indexSecondary = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primaryDiagonal += matrix[row, row];
            }

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                secondaryDiagonal += matrix[row, indexSecondary];
                indexSecondary++;
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
