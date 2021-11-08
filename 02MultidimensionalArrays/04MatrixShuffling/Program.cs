using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowCount = dimensions[0];
            int columnCount = dimensions[1];

            string[,] matrix = new string[rowCount, columnCount];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            string[] input = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            string command = input[0];

            while (command != "END")
            {
                if (command == "swap"
                    && int.TryParse(input[1], out int row1)
                    && int.TryParse(input[2], out int col1)
                    && int.TryParse(input[3], out int row2)
                    && int.TryParse(input[4], out int col2))
                {
                    if (row1 >= rowCount 
                        || row2 >= rowCount
                        || col1 >= columnCount
                        || col2 >= columnCount
                       )
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                       string previousValueCell1 = matrix[row1, col1];
                       string previousValueCell2 = matrix[row2, col2];

                        matrix[row1, col1] = previousValueCell2.ToString();
                        matrix[row2, col2] = previousValueCell1.ToString();

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }

                            Console.WriteLine();
                        }

                    }
                    

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    
                }


                input = Console.ReadLine()
                 .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
                command = input[0];
            }
        }
    }
}
