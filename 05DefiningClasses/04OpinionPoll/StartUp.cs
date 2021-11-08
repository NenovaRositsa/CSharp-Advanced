using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person currentPerson = new Person(name, age);


                people.Add(currentPerson);

            }

            people = GetAgeMoreThirtyYears(people);


            foreach (var person in people.OrderBy(x => x.Name))
            {
                Console.WriteLine(person);
            }
        }

        public static List<Person> GetAgeMoreThirtyYears(List<Person> allPeople)
        {
            allPeople = allPeople.Where(x => x.Age > 30).ToList();

            return allPeople;
        }
    }
}

