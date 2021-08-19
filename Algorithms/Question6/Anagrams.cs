using System;
using System.Collections.Generic;
using System.Text;

namespace Question6
{
    public class Anagrams
    {
        private static bool CheckAnagram(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }

            // Convert string to their respective character array  
            char[] firstCharsArray = firstString.ToLower().ToCharArray();
            char[] secondCharsArray = secondString.ToLower().ToCharArray();
            
            // Sort both array  
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);
            
            // Check each character  
            for (int index = 0; index < firstCharsArray.Length; index++)
            {
                if (firstCharsArray[index].ToString().CompareTo(secondCharsArray[index].ToString()) != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Initialize()
        {
            // Welcome message
            Console.WriteLine("Check Anagrams\n");

            // Read first string from user
            Console.Write("Enter first strings: ");
            string str1 = Console.ReadLine();

            // Read second string from user
            Console.Write("Enter first strings: ");
            string str2 = Console.ReadLine();
            Console.WriteLine("\n");

            // Call CheckAnagram method
            bool result = Anagrams.CheckAnagram(str1, str2);

            // Print result
            if (result)
            {
                Console.WriteLine($"{str1} and {str2} are anagrams\n");
            }
            else
            {
                Console.WriteLine($"{str1} and {str2} are not anagrams\n");
            }
        }
    }
}
