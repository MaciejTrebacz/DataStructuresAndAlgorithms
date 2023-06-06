using System;
using System.Diagnostics;

namespace DataStructuresAndAlgorithms.SpaceComplexity
{
    public class SpaceComplexity
    {
        public SpaceComplexity() { }
        public void boooo(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("boooo");
            }
            //space complexity O(1)
        }

        public int[] sayHi(int[] numbers)
        {
            var hiArray = new int[] { };
            for (int i = 0; i < numbers.Length; i++)
            {
                hiArray[i] = numbers[i];
            }
            return hiArray;
            //space complexity O(n)
        }
    }
}