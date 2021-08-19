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


            // check if both arrays are equal
            int trueCount = 0;
            foreach (var item1 in recursive)
            {
                int index = 0;
                foreach (var item2 in iterative)
                {
                    if (item1 == item2)
                    {
                        trueCount++;
                        break;
                    }
                }
            }


            if (trueCount == recursive.Length)
            {
                Console.WriteLine("Both arrays are equal");
            }
            else
            {
                Console.WriteLine("Both arrays are not equal");
            }
        }
    }
}
