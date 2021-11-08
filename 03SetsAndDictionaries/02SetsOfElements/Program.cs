using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstSetLength = input[0];
            int secondSetLength = input[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var resultSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                firstSet.Add(currentNumber);
                    
            }

            for (int i = 0; i < secondSetLength; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                secondSet.Add(currentNumber);
            }

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    resultSet.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", resultSet));
        }
    }
}
