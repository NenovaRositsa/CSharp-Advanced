using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int countRacks = 0;

            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            foreach (var item in stack)
            {
                int value = stack.Pop();

                
            }
        }


    }
}


//namespace P05FashionBoutique
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;

//    public class StartUp
//    {
//        public static void Main(string[] args)
//        {
//            int[] clothes = Console.ReadLine()
//                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
//                .Select(int.Parse)
//                .ToArray();
//            Stack<int> stack = new Stack<int>(clothes);
//            int capacity = int.Parse(Console.ReadLine());
//            int sum = 0;
//            int numberOfRacks = 1;

//            while (stack.Count > 0)
//            {
//                sum += stack.Peek();
//                if (sum <= capacity)
//                {
//                    stack.Pop();
//                }
//                else
//                {
//                    numberOfRacks++;
//                    sum = 0;
//                }

//            }
//            Console.WriteLine(numberOfRacks);
//        }
//    }
//}