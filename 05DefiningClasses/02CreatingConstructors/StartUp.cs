using System;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
      public  static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string currentName = input[0];
                int currentAge = int.Parse(input[1]);

                Person currentPerson = new Person(currentName, currentAge);

               family.AddMember(currentPerson);
            }

            Console.WriteLine(family.GetOldestMember());
        }

        
    }
}
