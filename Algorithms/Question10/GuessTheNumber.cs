using System;
using System.Collections.Generic;
using System.Text;

namespace Question10
{
    public class GuessTheNumber
    {
        // instance variables
        private long guess = -1;
        private long low = 0;
        private long high;

        const string TRUE = "true";

        // constructor
        public GuessTheNumber(long high)
        {
            this.high = high;
        }

        // Method to find the number while asking queries
        public void Search()
        {
            while (guess != low)
            {
                long mid = low + (high - low) / 2;

                Console.WriteLine($"\nIs your number -\ntrue: less than {mid}\nfalse: greater than {mid + 1}\n");
                string query = Console.ReadLine();

                if (query.ToLower() == TRUE)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }

                // Check if both low & high equal, stop the loop
                if (low == high)
                {
                    guess = low;
                }
            }

            // Print the guessed number
            Console.WriteLine($"The number is {guess}");
        }

    }
}
