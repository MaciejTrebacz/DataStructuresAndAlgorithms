using System;
using System.Linq;

namespace DataStructuresAndAlgorithms.Arrays
{
    public class ArrayExercises
    {

        public string ReverseString(string stringToReverse)
        {
            if (string.IsNullOrEmpty(stringToReverse) || stringToReverse.Length < 2 )
            {
                return "";
            }

            var result = "";

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                result += stringToReverse[i];

            }
            return result;
        }

        public string ReverseString2(string stringToReverse)
        {
            if (string.IsNullOrEmpty(stringToReverse) || stringToReverse.Length <2)
            {
                return "";
            }
            char[] reversedChars = stringToReverse.ToCharArray();
            
            Array.Reverse(reversedChars);

            return new string(reversedChars);
        }


        public int[] MergeSortedArray(int[] array1, int[] array2)
        {
            // check input
            if (array1 is null)
            {
                return array2;
            }

            if (array2 is null)
            {
                return array1;
            }
            int[] result = array1.Concat(array2).ToArray();
            Array.Sort(result);

            return result;
        }        
        
        public int[] MergeSortedArray2(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length+ array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                result[array1.Length+i] = array2[i];
            }
            Array.Sort(result);

            return result;
        }

        public int[] MergeSortedArray3(int[] array1, int[] array2)
        {
            int[] result = new int[ array1.Length+array2.Length ];
            array1.CopyTo(result,0);
            array2.CopyTo(result,array1.Length);
            Array.Sort(result);
            return result;
        }

        // nums = [2,5,5,11], target = 10
        public int[] TwoSum(int[] nums, int target)
        {
            var previousNum = 0;
            var result = new[] { 0, 0 };
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                for (int j = 0; j <= nums.Length-1; j++)
                {
                    Console.WriteLine($"{nums[i]} {nums[j]}");
                    if (nums[i] + nums[j] == target && i !=j)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }
        // nums = [-2,1,-3,4,-1,2,1,-5,4]
        public double SubArray(int[] nums)
        {
            double highestTwo = 0;
            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums.Length ==2)
            {
                return nums[0] + nums[1];
            }

            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length-1; j++)
                {
                    if (i+j > highestTwo)
                    {
                        highestTwo = nums[i] + nums[j];
                    }
                }
            }


            return highestTwo;
        }

        //nums = [0,1,0,3,12]
        //output = [1,3,12,0,0]
        public int[] MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]!=0)
                {
                    continue;
                }

                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j]==0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                }
            }

            return nums;
        }
    }
}