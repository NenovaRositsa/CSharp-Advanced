using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string, string> printFunc = x => $"Sir {x}";

            foreach (var item in input)
            {
                Console.WriteLine(printFunc(item));
            }

        }
    }
}
