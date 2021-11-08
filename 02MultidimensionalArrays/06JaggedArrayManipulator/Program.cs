using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] currentRow = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[row] = currentRow;
            }

            for (int r = 0; r < rows - 1; r++)
            {
                int currentRowLength = jaggedArray[r].Length;
                int nextRowLength = jaggedArray[r + 1].Length;

                if (currentRowLength == nextRowLength)
                {
                    for (int row = r; row <= r + 1; row++)
                    {
                        for (int col = 0; col < currentRowLength; col++)
                        {
                            jaggedArray[row][col] *= 2;
                        }
                    }
                }
                else
                {
                    for (int row = r; row <= r + 1; row++)
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {
                            jaggedArray[row][col] /= 2;
                        }
                    }
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitedInput = input
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = splitedInput[0];
                int row = int.Parse(splitedInput[1]);
                int col = int.Parse(splitedInput[2]);
                int value = int.Parse(splitedInput[3]);


                if (row >= 0 && row < jaggedArray.Length)
                {
                    if (col >= 0 && col < jaggedArray[row].Length)
                    {
                        if (command == "Add")
                        {
                            jaggedArray[row][col] += value;
                        }
                        else if (command == "Subtract")
                        {
                            jaggedArray[row][col] -= value;
                        }
                    }
                    else continue;
                }
                else continue;
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
