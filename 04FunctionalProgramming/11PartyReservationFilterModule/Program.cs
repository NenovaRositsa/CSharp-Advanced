using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split()
                .ToList();
            List<string> listsFromFilters = new List<string>();

            string input;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] splitedInput = input
                    .Split(';')
                    .ToArray();

                string command = splitedInput[0];


                if (command == "Add filter")
                {
                    listsFromFilters.Add($"{splitedInput[1]};{splitedInput[2]}");
                }
                else if (command == "Remove filter")
                {
                    listsFromFilters.Remove($"{splitedInput[1]};{splitedInput[2]}");
                }

            }

            Func<string, string, bool> startsWithFilter = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWithFilter = (name, param) => name.EndsWith(param);
            Func<string, string, bool> containsFilter = (name, param) => name.Contains(param);
            Func<string, int, bool> lengthFilter = (name, param) => name.Length == param;
            Action<List<string>> printAction = x => Console.WriteLine(string.Join(" ", x));


            foreach (var filter in listsFromFilters)
            {
                string[] splitedInfoFilter = filter.Split(';').ToArray();
                string typeOfFilter = splitedInfoFilter[0];
                string param = splitedInfoFilter[1];

                if (typeOfFilter == "Starts with")
                {
                    guests = guests.Where(name => !startsWithFilter(name, param)).ToList();
                }
                else if (typeOfFilter == "Ends with")
                {
                    guests = guests.Where(name => !endsWithFilter(name, param)).ToList();
                }
                else if (typeOfFilter == "Length")
                {
                    int value = int.Parse(param);

                    guests = guests.Where(name => !lengthFilter(name, value)).ToList();
                }
                else if (typeOfFilter == "Contains")
                {
                    guests = guests.Where(name => !containsFilter(name, param)).ToList();
                }
            }

            printAction(guests);
        }
    }
}
