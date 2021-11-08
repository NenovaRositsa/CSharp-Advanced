using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicalCompounds = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               string[] currentChemicalCompounds = ParseArrayFromConsole();

                foreach (var item in currentChemicalCompounds)
                {
                    chemicalCompounds.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", chemicalCompounds));
        }

        public static string[] ParseArrayFromConsole()
        {

            return Console.ReadLine()
                .Split()
                .ToArray();
        }
    }
}
