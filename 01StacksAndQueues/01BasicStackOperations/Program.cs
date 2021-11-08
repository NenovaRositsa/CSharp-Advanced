using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elements = input[0];
            int removedElements = input[1];
            int number = input[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elements; i++)
            {
                stack.Push(numbers[i]);
            }

           
            for (int i = 0; i < removedElements; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(number))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
