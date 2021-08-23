using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("UnOrdered List\n");


            // get array of words separated by ',' from the file
            string[] words = Operations.ReadFile("WordList.txt");


            // Object instantisation
            UnorderedList<string> linkedList = new UnorderedList<string>();


            // add each word to linkedList words
            foreach (var item in words)
            {
                linkedList.AddLast(item);
            }

            // print linkedList
            linkedList.Display();


            // search linkedList
            Operations.Search(linkedList);


            // print linkedList
            linkedList.Display();


            // save linkedList
            Operations.SaveFile("UpdatedWords.txt", linkedList);
        }
    }
}
