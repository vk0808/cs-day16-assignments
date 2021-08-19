using System;
using System.IO;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("Insertion Sort\n");

            // Path to txt file
            const string PATH = "../../../WordList.txt";

            // get array of words separated by ',' from the file
            string[] words = File.ReadAllText(PATH).Split(",");

            // print before sorting
            Console.WriteLine("Unsorted array: ");
            InsertionSort.Print(words);
            Console.WriteLine("\n");

            // sort the array
            InsertionSort.SortArray(words);

            // print after sorting
            Console.WriteLine("Sorted array: ");
            InsertionSort.Print(words);
        }
    }
}
