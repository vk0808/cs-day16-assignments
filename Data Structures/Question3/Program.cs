using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Simple Balanced Parentheses\n");

            // Expression stored to char array
            char[] exp = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8))/(4+3)".ToCharArray();


            // Print if expression is balanced or not
            if (Operations.AreBracketsBalanced(exp))
            {
                Console.WriteLine("Expression is balanced");
            }
            else
            {
                Console.WriteLine("Expression is not balanced");
            }
            
        }
    }
}
