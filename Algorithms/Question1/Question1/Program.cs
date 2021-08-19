using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("Permutations of a String using Iterative method and Recursion method\n");

            // object instansiation - recursive
            string[] recursive = Permutations.Recursive.performRec("ABC");

            // display result
            Console.Write("Recursive: ");
            foreach (var item in recursive)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine("\n");


            // object instansiation - iterative
            string[] iterative = Permutations.Iterative.performIter("ABC");

            // display result
            Console.Write("Iterative: ");
            foreach (var item in iterative)
            {
                Console.Write(item + " ");
            }
        }
    }
}
