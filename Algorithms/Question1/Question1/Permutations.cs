using System;
using System.Collections.Generic;
using System.Text;

namespace Question1
{
    public class Permutations
    {
        public class Recursive
        {
            public static List<string> listOfStrings = new List<string>();
           
            // Utility function to swap two characters in a character array
            private static void swap(char[] ch, int i, int j)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
            }

            // Recursive function to generate all permutations of a string
            private static void permutations(char[] ch, int currentIndex)
            {
                if (currentIndex == ch.Length - 1)
                {
                    // convert char to string and store in list
                    string str = ch[0].ToString();
                    for (var i=1; i < ch.Length; i++)
                    {
                        str += ch[i].ToString();
                    }
                    listOfStrings.Add(str);
                }

                for (int i = currentIndex; i < ch.Length; i++)
                {
                    swap(ch, currentIndex, i); 
                    permutations(ch, currentIndex + 1);
                    swap(ch, currentIndex, i); // to get back the original combination of string as before
                }
            }

            // generate all permutations of a string
            public static string[] perform(string s )
            {
                permutations(s.ToCharArray(), 0);
                return listOfStrings.ToArray();
            }
        }
    }
}
