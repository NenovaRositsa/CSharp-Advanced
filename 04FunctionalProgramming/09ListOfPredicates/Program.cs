using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOfTheRange = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>();
            List<int> result = new List<int>();

            for (int i = 1; i <= endOfTheRange; i++)
            {
                numbers.Add(i);
            }

            Func<int, int, bool> filterFunc = (x, y) => x % y == 0;
            bool isDivisibleOfAllDividers = false;


            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                for (int j = 0; j < dividers.Length; j++)
                {
                    int currentDivider = dividers[j];

                    if (filterFunc(currentNumber, currentDivider))
                    {
                        isDivisibleOfAllDividers = true;
                    }
                    else
                    {
                        isDivisibleOfAllDividers = false;
                        break;

                    }
                }

                if (isDivisibleOfAllDividers)
                {
                    result.Add(currentNumber);
                }
            }

            Action<List<int>> printAction = x => Console.WriteLine(string.Join(" ", x));

            printAction(result);
        }
    }
}
