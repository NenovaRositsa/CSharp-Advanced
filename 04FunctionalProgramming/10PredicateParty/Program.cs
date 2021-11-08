using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split()
                .ToList();



            Action<List<string>, string, string> removedNamesAction = (x, y, z) => 
            {
                

                if (y == "StartsWith")
                {
                    
                  guests.RemoveAll(p => p.StartsWith(z));

                }
                else if (y == "EndsWith")
                {
                    guests.RemoveAll(p => p.EndsWith(z));
                }
                else if (y == "Length")
                {
                    guests.RemoveAll(p => p.Length == int.Parse(z));
                }
            };

            Action<List<string>, string, string> doublesNamesAction = (x, y, z) =>
            {
                List<string> guestsToAdd = new List<string>();

                if (y == "StartsWith")
                {

                    guestsToAdd = guests.Where(p => p.StartsWith(z)).ToList();

                }
                else if (y == "EndsWith")
                {
                    guestsToAdd = guests.Where(p => p.EndsWith(z)).ToList();
                }
                else if (y == "Length")
                {
                    guestsToAdd = guests.Where(p => p.Length == int.Parse(z)).ToList();
                }

                foreach (var name in guestsToAdd)
                {
                    int index = guests.IndexOf(name);
                    guests.Insert(index + 1, name);

                }
            };



            Action<List<string>> printAction = x => Console.WriteLine(string.Join(", ", x) + " are going to the party!");

            string input = string.Empty;



            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] splitedInput = input.Split().ToArray();

                string command = splitedInput[0];
                string criteria = splitedInput[1];
                string value = splitedInput[2];

                if (command == "Double")
                {

                    doublesNamesAction(guests, criteria, value);

                }
                else if (command == "Remove")
                {
                    removedNamesAction(guests, criteria, value);
                }
            }

            if (guests.Any())
            {
                printAction(guests);
            }
            else
            {
                Console.WriteLine($"Nobody is going to the party!");
            }

        }
    }
}
