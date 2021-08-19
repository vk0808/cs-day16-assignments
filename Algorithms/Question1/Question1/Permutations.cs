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
            private static void permutationsRec(char[] ch, int currentIndex)
            {
                if (currentIndex == ch.Length - 1)
                {
                    // convert char to string and store in list
                    string str = new string(ch);
                    listOfStrings.Add(str);
                }

                for (int i = currentIndex; i < ch.Length; i++)
                {
                    swap(ch, currentIndex, i);
                    permutationsRec(ch, currentIndex + 1);
                    swap(ch, currentIndex, i); // to get back the original combination of string as before
                }
            }

            // generate all permutations of a string
            public static string[] performRec(string s)
            {
                permutationsRec(s.ToCharArray(), 0);
                return listOfStrings.ToArray();
            }
        }


        public class Iterative
        {
            public static List<string> listOfStrings = new List<string>();

            // function to return factorial of a number
            private static int factorial(int num)
            {
                int val = 1;
                for (int i = 2; i <= num; i++) {val *= i;}
                return val;
            }


            // iterative function to generate all permutations of a string
            private static void permutationsIter(string s)
            {
                int n = s.Length;
                int fact = factorial(n);

                for (int i = 0; i < fact; i++)
                {
                    StringBuilder sb = new StringBuilder(s);
                    int temp = i;
                    char[] ch = new char[n];
                    int index = 0;

                    for (int div = n; div >= 1; div--)
                    {
                        int q = temp / div;
                        int r = temp % div;
                        ch[index] = sb[r];

                        sb.Remove(r, 1);
                        temp = q;
                        index++;
                    }
                    string str = new string(ch);
                    listOfStrings.Add(str);
                }
            }

            // generate all permutations of a string
            public static string[] performIter(string s)
            {
                permutationsIter(s);
                return listOfStrings.ToArray();
            }
        }
    }
}
