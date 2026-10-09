using System.Collections;

namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Standard Bubble Sort
             * Even if an array becomes completely sorted early in the process
             * standard Bubble Sort continues running all $n - 1$ passes
             * resulting in unnecessary comparisons.
             */
            //int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            //Console.WriteLine("Original Array: " + string.Join(", ", numbers));

            //BubbleSortAlgorithm.OptimizesBubbleSort(numbers);

            //Console.WriteLine("Sorted Array:   " + string.Join(", ", numbers));
            #endregion

            #region Question 2
            //var range = new Range<int>(10, 25);

            //Console.WriteLine($"check 24 in range: {range.Inrange(24)}");
            //Console.WriteLine($"check 26 in range: {range.Inrange(26)}");
            //Console.WriteLine($"the rang is :{range.Length()}");

            #endregion

            #region Question 3
            //ArrayList list = new ArrayList { 1, "Two", 3.0, '4', true };

            //Console.WriteLine("Original ArrayList: " + string.Join(", ", list.ToArray()));

            //ReversArrayList.Revers(list);

            //Console.WriteLine("Reversed ArrayList: " + string.Join(", ", list.ToArray()));
            #endregion

            #region Question 4
            //List<int> originalNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 22 };

            //Console.WriteLine("Original List: " + string.Join(", ", originalNumbers));

            //List<int> evens = EvenNumbersList.GetEvenNumbers(originalNumbers);

            //Console.WriteLine("Even Numbers:  " + string.Join(", ", evens));
            #endregion

            #region Question 5
            //var list = new FixedSizeList<string>(3);

            //// Adding items within capacity
            //list.Add("C#");
            //list.Add(".NET Core");
            //list.Add("SQL Server");

            //Console.WriteLine($"Item at index 0: {list.Get(0)}");
            //Console.WriteLine($"Item at index 1: {list.Get(1)}");
            //Console.WriteLine($"Item at index 2: {list.Get(2)}");

            //// Testing Exceeding Capacity Exception
            //try
            //{
            //    Console.WriteLine("\nAttempting to add a 4th item...");
            //    list.Add("Docker");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Caught Expected Exception: {ex.Message}");
            //}

            //// Testing Invalid Index Exception
            //try
            //{
            //    Console.WriteLine("\nAttempting to access index 5...");
            //    Console.WriteLine(list.Get(5));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Caught Expected Exception: {ex.Message}");
            //}
            #endregion

            #region Question 6
            //string s1 = "aabb";
            //string s2 = "bodobdtr";
            

            //Console.WriteLine($"{s1} -> Index: {FirstUniqueChar.FindFirstUniqChar(s1)}"); 
            //Console.WriteLine($"{s2} -> Index: {FirstUniqueChar.FindFirstUniqChar(s2)}"); 
        }
            #endregion
    }
    
}
