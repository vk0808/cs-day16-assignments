using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    public class Bank
    {
        public static void CashCounter()
        {
            // local variables
            int IS_BUSY = 1;
            int tokenNumber = 1;
            int choice = 1;

            // Get bank balance
            Console.WriteLine("Enter the Cash Balance");
            double balance = double.Parse(Console.ReadLine());

            // Object instantiation
            Queue<string> queue = new Queue<string>();
            Random rand = new Random();

            while (choice > 0)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("\nSelect one: \n1. Deposit\n2. Withdraw\n3. Number of people in queue\n4. Exit\n");
                Console.Write("Enter the choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Do deposit
                        Console.Write("\nEnter the amount to deposit: ");
                        balance += double.Parse(Console.ReadLine());
                        queue.Enqueue("TN00" + tokenNumber.ToString());
                        tokenNumber++;
                        break;

                    case 2: // Do withdrawal
                        Console.Write("\nEnter the amount to withdraw: ");
                        double amount = double.Parse(Console.ReadLine());
                        
                        // Check if there is sufficient balance
                        if (balance - amount > 0)
                        {
                            queue.Enqueue("TN00" + tokenNumber.ToString());
                            tokenNumber++;
                            balance -= amount;
                        }
                        else
                        {
                            Console.WriteLine("\nInsufficient funds");
                        }
                        break;

                    case 3: // Check queue length
                        Console.WriteLine($"\nQueue count: {queue.Count()}");
                        break;

                    case 4: // Exit
                        Console.WriteLine("\nExiting....");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nWrong input");
                        break;
                }

                // Display people in queue
                Console.Write("\nPeople in Queue(Token Numbers): ");
                queue.Display();
                Console.WriteLine("\n");

                // Randomly perform dequeue operation if the cash counter is not busy
                if (rand.Next(0,2) != IS_BUSY)
                {
                    queue.Dequeue();
                }
            }
        }
    }
}
