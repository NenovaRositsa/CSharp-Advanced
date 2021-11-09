using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            List<int> result = new List<int>();

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int currentFirstBoxElement = firstBox.Peek();
                int currentSecondBoxElement = secondBox.Peek();
                int sum = currentFirstBoxElement + currentSecondBoxElement;

                if (sum % 2 == 0)
                {
                    result.Add(sum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    secondBox.Pop();
                    firstBox.Enqueue(currentSecondBoxElement);
                }


            }

            if (!firstBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (!secondBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (result.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {result.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {result.Sum()}");
            }

        }
    }
}
