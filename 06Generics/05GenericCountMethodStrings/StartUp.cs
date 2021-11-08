using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Count_Method_Strings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> elements = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double currentElement = double.Parse(Console.ReadLine());

                elements.Add(currentElement);

            }

            double elementToCompare = double.Parse(Console.ReadLine());
            int count = elements.ComparesElements(elements, elementToCompare);

            Console.WriteLine(count);


        }
    }
}
