using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofInteger
{
    public class Box<T>
    {
        private T input;

        public Box(T input)
        {
            this.input = input;
        }

        public override string ToString()
        {
            return $"{this.input.GetType()}: {this.input}"; 
        }
    }
}
