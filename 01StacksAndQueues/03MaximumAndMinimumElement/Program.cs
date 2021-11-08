using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                int command = input[0];

                if (command == 1)
                {
                    int element = input[1];
                    stack.Push(element);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }

                }
                else if (command == 4)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }

                }

            }

            Console.WriteLine(string.Join(", ", stack));

        }
    }
}
