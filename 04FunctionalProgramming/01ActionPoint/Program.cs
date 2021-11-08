using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Action<string[]> printAction = PrintOntoConsole;
            printAction(input);
                
        }

        public static void PrintOntoConsole(string[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
