using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10
{
    public class EvenNumbersList
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            if (numbers == null)
                return new List<int>();
            
            return numbers.Where(n=>n%2==0).ToList();
        }
    }
}
