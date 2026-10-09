using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10
{
    public class ReversArrayList
    {
        public static void Revers(ArrayList array)
        {
            if (array == null || array.Count <= 1) return;

            int left = 0;
            int right = array.Count - 1;

            while (left < right)
            {
                object temp = array[left]!;
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
        }
    }
}
