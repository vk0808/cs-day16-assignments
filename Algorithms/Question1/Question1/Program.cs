using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("Permutations of a String using Iterative method and Recursion method\n");

            // object instansiation
            string[] recursive = Permutations.Recursive.perform("ABC");
            
            // display result
            foreach (var item in recursive)
            {
                Console.Write(item + " ");
            }
        }
    }
}
