using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("Ordered List");


            // get array of numbers separated by ',' from the file
            string[] numbers = Operations.ReadFile("NumberList.txt");


            // Object instantisation
            OrderedList<int> linkedList = new OrderedList<int>();


            // add each number to linkedList words
            foreach (var item in numbers)
            {
                linkedList.Insert(int.Parse(item));
            }

            // print linkedList
            linkedList.Display();


            // search linkedList
            Operations.Search(linkedList);


            // print linkedList
            linkedList.Display();


            // save linkedList
            Operations.SaveFile("UpdatedNumbers.txt", linkedList);
        }
    }
}
