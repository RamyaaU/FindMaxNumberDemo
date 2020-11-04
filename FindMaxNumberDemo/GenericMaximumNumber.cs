using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxNumberDemo
{
    public class GenericMaximumNumber<T> where T:IComparable
    {
        public T[] value;

        public GenericMaximumNumber(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values;
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void printMaxvalue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is : ");
        }
    }
}
