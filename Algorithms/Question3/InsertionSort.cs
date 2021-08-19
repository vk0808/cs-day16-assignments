using System;
using System.Collections.Generic;
using System.Text;

namespace Question3
{
    public class InsertionSort
    {
        // method to sort array
        public static void SortArray(string[] array)
        {
            int n = array.Length;
            // unsorted array starts from index:1
            for (int i = 1; i < n; ++i)
            {
                // sorted array starts from index:0
                string current = array[i];
                int prev = i - 1;

                while (prev >= 0 && array[prev].CompareTo(current) > 0)
                {
                    array[prev + 1] = array[prev];
                    prev -=  1;
                }
                array[prev + 1] = current;
            }
        }

        // method to print array
        public static void Print(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }
    }
}
