using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Swap_Method_Strings
{
    public class Box<T>
    {
        private List<T> boxItems;

        public Box()
        {
            this.boxItems = new List<T>();
        }

        public void Add(T item)
        {
            this.boxItems.Add(item);
        }

        public void SwapElements(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex >= boxItems.Count
                || secondIndex < 0 || secondIndex >= boxItems.Count)
            {
                throw new Exception("Invalid index");
            }
            else
            {
                T temp = boxItems[firstIndex];
                boxItems[firstIndex] = boxItems[secondIndex];
                boxItems[secondIndex] = temp;

            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            foreach (var item in boxItems)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
