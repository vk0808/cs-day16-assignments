using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    public class BubbleSort
    {
        // method to sort array
        public static void SortArray(string[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) >0)
                    {
                        // swap array[j] and array[j+1]
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


        // method to print Array
        public static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
