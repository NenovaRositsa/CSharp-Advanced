using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, 1);
                }
                else
                {
                    dictionary[number]++;
                }

            }

            var result = dictionary.Where(x => x.Value % 2 == 0);

            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key);
            }
                
        }
    }
}
