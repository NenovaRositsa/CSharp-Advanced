using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Queue_Operations
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

            Queue<int> Queue = new Queue<int>();

            for (int i = 0; i < elements; i++)
            {
                Queue.Enqueue(numbers[i]);
            }


            for (int i = 0; i < removedElements; i++)
            {
                Queue.Dequeue();
            }

            if (Queue.Contains(number))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (Queue.Any())
                {
                    Console.WriteLine(Queue.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
