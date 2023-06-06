using System;
using System.Linq;

namespace DataStructuresAndAlgorithms.BigO
{
    public class OeN
    {
        // create arrayOfStrings 

        public void findArray()
        // its O(n) bigO depends of number of inputs (size of array)
        {

            string[] arrayOfStrings = { "nemo", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", "polska", };

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                if (arrayOfStrings[i] != "nemo") continue;
                Console.WriteLine($"Found nemo at index {i}");
                break;
            }
        }
    }
}