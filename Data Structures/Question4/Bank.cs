using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    public class Bank
    {
        public static void CashCounter()
        {
            int tokenNumber = 1;
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Enter the Cash Balance");
            double balance = double.Parse(Console.ReadLine());

            int choice = 1;

            while (choice < 5)
            {
                Console.WriteLine("\nEnter the choice: \n1. Deposit\n2. Withdraw\n3. Number of people in queue\n4. Exit\n");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter the amount to deposit: ");
                        balance += double.Parse(Console.ReadLine());
                        queue.Enqueue(tokenNumber);
                        tokenNumber++;
                        break;

                    case 2:
                        Console.Write("\nEnter the amount to withdraw: ");
                        double amount = double.Parse(Console.ReadLine());
                        if (balance - amount > 0)
                        {
                            queue.Enqueue(tokenNumber);
                            tokenNumber++;
                            balance -= amount;
                        }
                        else
                        {
                            Console.WriteLine("\nInsufficient funds");
                        }
                        break;

                    case 3:
                        Console.WriteLine($"\nQueue count: {queue.Count()}");
                        break;

                    case 4:
                        Console.WriteLine("\nExiting....");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nWrong input");
                        break;
                }

                Console.Write("\nQueue: ");
                queue.Display();
            }
        }
    }
}
