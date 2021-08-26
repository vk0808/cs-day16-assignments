using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
			bool flag = true;

			// Welcome message
			Console.WriteLine("Palindrome Checker\n");
			

			// Object instantiation
			Deque<char> deque = new Deque<char>();


			// Get string and convert to character array
			Console.Write("Enter a string: ");
			char[] charArray = Console.ReadLine().ToCharArray();


            // Add each character to the rear of the deque
            foreach (var item in charArray)
			{
				deque.AddRear(item);
			}


			// Check if characters from front and rear are same time after removing
			while (deque.Size() > 1)
			{
				if (deque.RemoveFront() != deque.RemoveRear())
				{
					flag = false; // flag if it's not same
					break;
				}
			}


			// Print the result
			if (flag)
			{
				Console.WriteLine("\nString is palindrome");
			}
			else
			{
				Console.WriteLine("\nString is not palindrome");
			}
		}
    }
}
