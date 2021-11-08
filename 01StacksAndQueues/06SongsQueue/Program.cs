using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Any())
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string command = input[0];

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {
                    string currentSong = string.Join(" ", input.Skip(1));


                    if (queue.Contains(currentSong))
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(currentSong);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
