using System;
using System.IO;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("Bubble Sort\n");


            // Path to txt file
            const string PATH = "../../../WordList.txt";

            // get array of words separated by ',' from the file
            string[] words = File.ReadAllText(PATH).Split(",");

            // print before sorting
            Console.WriteLine("Unsorted array: ");
            BubbleSort.Print(words);
            Console.WriteLine("\n");

            // sort the array
            BubbleSort.SortArray(words);

            // print after sorting
            Console.WriteLine("Sorted array: ");
            BubbleSort.Print(words);
        }
    }
}
