using System;
using System.IO;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search the Word from Word List\n");

            // Path to txt file
            const string PATH = "../../../WordList.txt";

            // get array of words separated by ',' from the file
            string[] words = File.ReadAllText(PATH).Split(",");

            // sort the array
            Array.Sort(words, StringComparer.InvariantCulture);
            
            // display the array
            Array.ForEach(words, item => Console.Write(item + " "));

            Console.WriteLine("\n");
            // get the word to search from the user
            Console.Write("Enter the word you want to search: ");
            string searchKey = Console.ReadLine();

            // object instantisation
            BinarySearch bs = new BinarySearch(searchKey, words);

            // call search method
            bs.performSearch();
        }
    }
}
