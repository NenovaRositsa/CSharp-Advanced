using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = input[0];
                string[] clothes = input[1].Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();

                    foreach (var item in clothes)
                    {
                        if (!wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item] = 1;
                        }
                        else
                        {
                            wardrobe[color][item]++;
                        }
                        
                    }
                }
                else
                {
                    foreach (var item in clothes)
                    {
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
            }

            string[] infoForWantedItem = Console.ReadLine()
                .Split()
                .ToArray();

            string colorWantedItem = infoForWantedItem[0];
            string wantedItem = infoForWantedItem[1];

            foreach (var item in wardrobe)
            {

                Console.WriteLine($"{item.Key} clothes:");

                foreach (var kvp in item.Value)
                {

                    if (kvp.Key == wantedItem && item.Key == colorWantedItem)
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value}");
                    }

                }
            }
        }
    }
}
