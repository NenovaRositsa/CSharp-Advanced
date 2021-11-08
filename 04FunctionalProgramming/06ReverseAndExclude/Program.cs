using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int integer = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> func = CalculationAndRemovesElements;

            numbers = func(numbers, integer);

            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));
                

        }

        public static List<int> CalculationAndRemovesElements(List<int> input, int number)
        {
            input = input.Where(x => x % number != 0).ToList();

            return input;
        }
    }
}
