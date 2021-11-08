using System;
using System.Linq;
using System.Text;

namespace Threeuple
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine()
                .Split().ToArray();
            string fullName = $"{nameAndAddress[0]} {nameAndAddress[1]}";
            string address = nameAndAddress[2];
            string[] townArr = nameAndAddress.Skip(3).ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var item in townArr)
            {
                sb.Append($"{item} ");
            }

            string town = sb.ToString();

            string[] nameAndBeer = Console.ReadLine()
                .Split()
                .ToArray();
            string name = nameAndBeer[0];
            int liters = int.Parse(nameAndBeer[1]);
            string drunkInfo = nameAndBeer[2];
            bool drunkOrNot = false;

            if (drunkInfo.Equals("drunk"))
            {
                drunkOrNot = true;
            }

            string[] thirdInput = Console.ReadLine()
                .Split()
                .ToArray();
            string firstArgument = thirdInput[0];
            double secondArgument = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            Tuple<string, string, string> firstTuple = new Tuple<string, string, string>(fullName, address, town);
            Tuple<string, int, bool> secondTuple = new Tuple<string, int, bool>(name, liters, drunkOrNot);
            Tuple<string, double, string> thirdTuple = new Tuple<string, double, string>(firstArgument, secondArgument, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);


        }
    }
}
