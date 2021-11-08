using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minNumbersFunc = x => x.Min();

            Console.WriteLine(minNumbersFunc(numbers));

        }
    }
}
