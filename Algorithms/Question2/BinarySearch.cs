using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    public class BinarySearch
    {
        // instance variable
        string _search;
        string[] _array;

        // constructor
        public BinarySearch(string search, string[] array)
        {
            this._search = search;
            this._array = array;
        }

        // method to perform binary search
        private bool Search(int high, int low)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (this._search == this._array[mid])
                {
                    return true;
                }
                else if (this._search.CompareTo(this._array[mid]) < 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return false;
        }

        // method to call binary search and display result
        public void performSearch()
        {
            int high = this._array.Length - 1;
            int low = 0;
            bool res = Search(high, low);

            if (res)
            {
                Console.WriteLine("Found\n");
            }
            else
            {
                Console.WriteLine("Not found\n");
            }
        }
    }
}
