using System;
using System.Collections.Generic;
using System.Text;

namespace Question3
{
    public class Operations
    {
        // Method to check if opening and closing brackets are present in params
        public static bool DoesPairMatch(char openingBracket, char closingBracket)
        {
            if (openingBracket == '(' && closingBracket == ')')
            {
                return true;
            }

            else if (openingBracket == '{' && closingBracket == '}')
            {
                return true;
            }

            else if (openingBracket == '[' && closingBracket == ']')
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Method to add brackets to stack and remove based on the type of brackets
        public static bool AreBracketsBalanced(char[] exp)
        {
            // Declare an empty character stack with maxSize = 100
            Stack<char> stack = new Stack<char>(100);

            // Traverse the given expression to check matching brackets
            for (int i = 0; i < exp.Length; i++)
            {
                // If the exp[i] is a starting bracket then push it
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                {
                    stack.Push(exp[i]);
                }

                //  If exp[i] is an ending bracket then pop from stack and check if the popped bracket is a matching pair
                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    // If we see an ending bracket without a pair then return false
                    if (stack.Size() == 0)
                    {
                        return false;
                    }
                    
                    else if (!DoesPairMatch(stack.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }

            // If there is something left in expression then it is not balanced
            if (stack.Size() == 0)
            {
                return true; // balanced
            }
            else
            {
                return false; // not balanced
            }
        }
    }
}
