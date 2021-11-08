using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfName = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, bool> func = x => x.Length <= lengthOfName;

            foreach (var item in names)
            {
                if (func(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
