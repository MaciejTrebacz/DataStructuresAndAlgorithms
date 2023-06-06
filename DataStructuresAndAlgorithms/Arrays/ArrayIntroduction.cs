using System;

namespace DataStructuresAndAlgorithms.Arrays
{
    public class ArrayIntroduction
    {
        string[] strings = {"a","b","c","d","e"};
        private int[] intArray = {};


        // Make a variable to keep the length because .Length is based off capacity and does track actual index

        public void AddAtTheEndOfArray()
        {
    
            // add data to intArray
            for (int i = 0; i < 3; i++)
            {
                Array.Resize(ref intArray, intArray.Length + 1);
                intArray[i] = i+1;
            }
            
            // inserting in the end
            intArray[intArray.Length-1] = 8;
            // resize array 
            Array.Resize(ref intArray, intArray.Length+1);
            // set value method insert at the end
            intArray.SetValue(99,intArray.Length-1);

        }


        public void InsertAtTheStartOfTheArray()
        {
            Array.Resize(ref strings,strings.Length+1);
            for (int i = strings.Length-2; i >= 0; i--)
            {
                //shifting
                strings[i+1] = strings[i];
            }

            strings[0] = "z";
        }

        public void InsertAnywhereInArray()
        {
            string[] alphabet = { "a", "b", "c", "d","e", "f","g","h"};
            Array.Resize(ref alphabet, alphabet.Length + 1);

            // i>= 2 == 2 is index where we wanna make insertion
            for (int i = alphabet.Length-2; i >= 2; i--)
            {
                // shift each element one position to the right
                alphabet[i + 1] = alphabet[i];
            }

            alphabet[2] = "i";
            Array.Resize(ref alphabet, alphabet.Length-1);
        }
        

    }
}