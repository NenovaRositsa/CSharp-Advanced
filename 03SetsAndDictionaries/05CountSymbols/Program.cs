using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> symbols = new Dictionary<char, int>();

            char[] text = input.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (!symbols.ContainsKey(currentSymbol))
                {
                    symbols.Add(currentSymbol, 1);
                }
                else
                {
                    symbols[currentSymbol]++;
                }
            }

            foreach (var kvp in symbols.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }

        }
    }
}
