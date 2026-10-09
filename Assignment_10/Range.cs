using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10
{
    public class Range<T> where T : IComparable<T>
    {
        public T mini {  get; }
        public T max { get; }

        public Range(T mini, T max)
        {
            if(mini.CompareTo(max) > 0)
            {
                T tmp = mini; 
                mini = max;
                max = tmp;
            }
            this.mini = mini;
            this.max = max;
        }

        public bool Inrange(T value)
        {
            if (value is null) return false;

            return value.CompareTo(mini) >=0 && value.CompareTo(max) <= 0;
        }

        public dynamic Length()
        {
            return (dynamic)max-(dynamic) mini;
        }
    }
}
