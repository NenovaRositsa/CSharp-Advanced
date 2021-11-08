namespace _08._Custom_Comparator
{
    using System;
    using System.Linq;
    class CustomComparator
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            Func<int[], int[]> filterEvenNumbers = x => x.Where(y => y % 2 == 0).ToArray();
            Func<int[], int[]> filterOddNumber = x => x.Where(y => y % 2 != 0).ToArray();

            int[] evenNumbers = filterEvenNumbers(input);
            int[] oddNumbers = filterOddNumber(input);

            Array.Sort(evenNumbers);
            Array.Sort(oddNumbers);

            Action<int[]> printAction = x => Console.Write(string.Join(" ", x));

            printAction(evenNumbers);
            Console.Write(" ");
            printAction(oddNumbers);
            Console.WriteLine();
        }
    }
}