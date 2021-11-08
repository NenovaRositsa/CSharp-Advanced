using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rowSize = sizes[0];
            int columnSize = sizes[1];

            char[,] matrix = new char[rowSize, columnSize];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] charactersCurrentRow = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = charactersCurrentRow[c];
                }

                Console.WriteLine();
            }

            int equalSquares = 0;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                 for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    if (matrix[r, c] == matrix[r, c + 1]
                        && matrix[r + 1, c] == matrix[r+1, c+1] 
                        && matrix[r, c] == matrix[r+1, c+1])
                    {
                        equalSquares++;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine(equalSquares);

        }
    }
}
