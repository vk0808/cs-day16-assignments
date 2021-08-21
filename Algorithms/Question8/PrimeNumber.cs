using System;
using System.Collections.Generic;
using System.Text;

namespace Question8
{
    public class PrimeNumber
    {
        // Function to get prime numbers in the form of true or false stored in array 
        private static bool[] SieveOfEratosthenes(int number)
        {
            // Create a boolean array
            bool[] array = new bool[number + 1];

            // Initialize each element of bool array to true
            for (int i = 0; i < number; i++)
            {
                array[i] = true;
            }

            for (int p = 2; p * p <= number; p++)
            {
                // Check if array[p] is not changed, then it is a prime
                if (array[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * p; i <= number; i += p)
                        array[i] = false;
                }
            }
            return array;
        }

        // Function to print prime numbers
        public static void Find(int number)
        {
            // Call SieveOfEratosthenes function
            bool[] primes = SieveOfEratosthenes(number);

            for (int i = 2; i <= number; i++)
            {
                if (primes[i] == true && IsPalindrome(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
        

        private static bool IsPalindrome(int number)
        {
            int length = number.ToString().Length;
            string digits = number.ToString();

            for (int i = 0; i < length; i++)
            {
                if (digits[i] != digits[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
