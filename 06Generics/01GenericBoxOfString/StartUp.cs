using System;
using System.Collections.Generic;

namespace GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());  
                Box<int> item = new Box<int>(input);

                Console.WriteLine(item);

            }

        }
    }
}
