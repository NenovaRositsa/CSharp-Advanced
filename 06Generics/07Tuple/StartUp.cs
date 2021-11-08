using System;
using System.Linq;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine()
                .Split().ToArray();
            string fullName = $"{nameAndAddress[0]} {nameAndAddress[1]}";
            string address = nameAndAddress[2];

            string[] nameAndBeer = Console.ReadLine()
                .Split()
                .ToArray();
            string name = nameAndBeer[0];
            int liters = int.Parse(nameAndBeer[1]);

            string[] thirdInput = Console.ReadLine()
                .Split()
                .ToArray();
            int firstArgument = int.Parse(thirdInput[0]);
            double secondArgument = double.Parse(thirdInput[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, liters);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(firstArgument, secondArgument);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);


        }
    }
}
