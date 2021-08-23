using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Question2
{
    public class Operations
    {
        // method to read file
        public static string[] ReadFile(string filename)
        {
            string path = "../../../" + filename;
            return File.ReadAllText(path).Split(",");
        }


        // method to save file
        public static void SaveFile(string filename, OrderedList<int> linkedList)
        {
            string path = @"../../../" + filename;

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < linkedList.Count(); i++)
                {
                    writer.WriteLine(linkedList.GetValue(i));
                }
            }

            Console.WriteLine($"\nSaved to file {filename}");
        }

        public static void Search(OrderedList<int> linkedList)
        {
            // get the search term
            Console.Write("\nEnter the number to search: ");
            int search = int.Parse(Console.ReadLine());


            // perform operations for the search term
            if (linkedList.Search(search))
            {
                Console.WriteLine("Found");
                linkedList.Remove(search);
            }
            else
            {
                Console.WriteLine("Not Found");
                linkedList.Insert(search);
            }
        }
    }
}
