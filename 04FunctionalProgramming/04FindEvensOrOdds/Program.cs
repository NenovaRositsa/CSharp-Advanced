using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boundaries = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lowBound = boundaries[0];
            int upperBound = boundaries[1];

            string command = Console.ReadLine();

            Action<int, int, string> filterAction = PrintNumbers;

            filterAction(lowBound, upperBound, command);
        }

        public static void PrintNumbers(int lowBound, int upperBound, string command)
        {
            if (command == "even")
            {
                for (int i = lowBound; i <= upperBound; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else if (command == "odd")
            {
                for (int i = lowBound; i <= upperBound; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

        }
    }
}
