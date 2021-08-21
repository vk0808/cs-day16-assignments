using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Guess the number\n");

            // Get the number
            Console.Write("Enter the scope range number: ");
            long num = long.Parse(Console.ReadLine());

            // Object instantisation
            GuessTheNumber guess = new GuessTheNumber(num);
            guess.Search();
        }
    }
}
