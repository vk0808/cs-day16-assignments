using System;
using System.IO;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Merge Sort\n");

            // Path to txt file
            const string PATH = "../../../WordList.txt";

            // get array of words separated by ',' from the file
            string[] words = File.ReadAllText(PATH).Split(",");

            // print before sorting
            Console.WriteLine("Unsorted array: ");
            MergeSort.Print(words);
            Console.WriteLine("\n");

            // sort the array
            MergeSort.SortArray(words, 0, words.Length - 1);

            // print after sorting
            Console.WriteLine("Sorted array: ");
            MergeSort.Print(words);
        }
    }
}
