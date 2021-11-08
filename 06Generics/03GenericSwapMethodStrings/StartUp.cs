using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Swap_Method_Strings
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);
            }

            int[] inputIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int firstIndex = inputIndexes[0];
            int secondIndex = inputIndexes[1];

            box.SwapElements(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
