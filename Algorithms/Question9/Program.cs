using System;
using System.IO;

namespace Question9
{
    class Program
    {
        public static void initiateBinarySearch()
        {
            // Path to txt file
            const string PATH = "../../../WordList.txt";

            // get array of words separated by ',' from the file
            string[] words = File.ReadAllText(PATH).Split(",");

            // sort the array
            Array.Sort(words, StringComparer.InvariantCulture);

            Console.WriteLine("\n");
            // get the word to search from the user
            Console.Write("Enter the word you want to search: ");
            string searchKey = Console.ReadLine();

            // object instantisation
            BinarySearch<string> bs = new BinarySearch<string>(searchKey, words);

            // call search method
            bs.performSearch();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Rewrite using Generics\n");

            initiateBinarySearch();
        }
    }
}
