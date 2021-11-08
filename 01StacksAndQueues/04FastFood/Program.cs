using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(input);

            Console.WriteLine(orders.Max());


            foreach (var order in input.Reverse())
            {
                if (order <= quantity)
                {
                    orders.Dequeue();
                    quantity -= order;

                    if (orders.Count == 0)
                    {
                        Console.WriteLine("Orders complete");
                    }
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;

                }
            }


        }
    }
}
