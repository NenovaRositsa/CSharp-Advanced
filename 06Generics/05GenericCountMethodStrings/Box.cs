using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Generic_Count_Method_Strings
{
    public class Box<T> where T : IComparable
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

        public int ComparesElements(Box<T> items, T elementToCompare)
        {
            int count = 0;

            foreach (var item in boxItems)
            {
                if (elementToCompare.CompareTo(item) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
