using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10
{
    public class BubbleSortAlgorithm
    {
        public static void OptimizesBubbleSort(int[] arr)
        {
            if (arr == null || arr.Length <=1) return;
            bool swaped;
            for(int i = 0; i < arr.Length-1; i++)
            {
                swaped = false;
                for(int j = 0;j<arr.Length-i-1;j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                        swaped=true;
                    }
                }
                // If no swaps occurred during this pass, array is sorted
                if (!swaped)
                    break;
       
            }
        }
    }
}
