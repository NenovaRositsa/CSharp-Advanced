using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] splitedInput = input
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = splitedInput[1];

                if (command == "joined")
                {
                    string vloggername = splitedInput[0];

                    if (!dictionary.ContainsKey(vloggername))
                    {
                        dictionary.Add(vloggername, new List<string>());
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "followed")
                {
                    string firstVloggername = splitedInput[0];
                    string secondVloggername = splitedInput[2];
                }
            }
        }
    }
}
