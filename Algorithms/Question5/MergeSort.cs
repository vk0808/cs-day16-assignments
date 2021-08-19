using System;
using System.Collections.Generic;
using System.Text;

namespace Question5
{
    public class MergeSort
    {
        // Function to compare two sub-arrays and then merge 
        private static void Merge(string[] array, int left, int mid, int right)
        {
            // Find size of two sub-arrays to be merged
            int sizeSub1 = mid - left + 1;
            int sizeSub2 = right - mid;

            // Create two temp arrays
            string[] Left = new string[sizeSub1];
            string[] Right = new string[sizeSub2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < sizeSub1; ++i)
            {
                Left[i] = array[left + i];
            }
            for (j = 0; j < sizeSub2; ++j)
            {
                Right[j] = array[mid + 1 + j];
            }

            // Initial indexes of first and second sub-arrays
            i = 0;
            j = 0;

            // Initial index for the merged sub-array
            int k = left;

            // Loop to compare and save to the merged sub-array
            while (i < sizeSub1 && j < sizeSub2)
            {
                if (Left[i].CompareTo(Right[j]) <= 0)
                {
                    array[k] = Left[i];
                    i++;
                }
                else
                {
                    array[k] = Right[j];
                    j++;
                }
                k++;
            }

            // Copy remaining values of L[]
            while (i < sizeSub1)
            {
                array[k] = Left[i];
                i++;
                k++;
            }

            // Copy remaining values of R[]
            while (j < sizeSub2)
            {
                array[k] = Right[j];
                j++;
                k++;
            }
        }

        // Function to sort array and then call merge
        public static void SortArray(string[] array, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int m = left + (right - left) / 2;

                // Sort first and second halves
                SortArray(array, left, m);
                SortArray(array, m + 1, right);

                // Merge the sorted halves
                Merge(array, left, m, right);
            }
        }

        // Function to print array
        public static void Print(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
