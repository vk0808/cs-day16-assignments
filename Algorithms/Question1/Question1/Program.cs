using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("Permutations of a String using Iterative method and Recursion method\n");


            string str = "ABC";

            // object instansiation - recursive
            string[] recursive = Permutations.Recursive.performRec(str);

            // display result
            Console.Write("Recursive: ");
            foreach (var item in recursive)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");


            // object instansiation - iterative
            string[] iterative = Permutations.Iterative.performIter(str);

            // display result
            Console.Write("Iterative: ");
            foreach (var item in iterative)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");


            // check if both arrays are equal
            int trueCount = 0;
            foreach (var item1 in recursive)
            {
                foreach (var item2 in iterative)
                {
                    if (item1 == item2)
                    {
                        trueCount++;
                        break;
                    }
                }
            }

            // check if the true count is equal to length
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
