using System;
using System.IO;

namespace Question1
{
    class Program
    {
        // method to read file
        static string[] ReadFile(string path)
        {
            return File.ReadAllText(path).Split(",");
        }


        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("UnOrdered List\n");

            // Path to txt file
            const string PATH = "../../../WordList.txt";

            // get array of words separated by ',' from the file
            string[] words = ReadFile(PATH);

            // print words
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
    }
}
