using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DataStructuresAndAlgorithms.CodingProblems
{
    public class InterviewQuestion
    {
        public char[] array1 = { 'a', 'b', 'c', 'x' };
        public char[] array2 = { 'z', 'y', 'x' };

        public bool FindCommon()
        {
            return array1.Any(a1 => array2.Contains(a1));
        }



        public void FindCommon2()
        {
            // loop through first array and create object with properties === items in array 
            // array1 ==> obj {
            //         a: true,
            //         b: true,
            //         c: true,
            //         x: true,

            // loop through second array and check if item in second array exists on created object
            List<KeyValueObject> keyValueObjectsList = new List<KeyValueObject>();
            
            for (int i = 0; i < array1.Length; i++)
            {
                
                keyValueObjectsList.Add(new KeyValueObject(array1[i],true));

            }

            //for (int j = 0; j < array2.Length; j++)
            //{
            //    if (keyValueObjectsList.)
            //    {
                    
            //    }
            //}


            keyValueObjectsList.ForEach(x=> Console.WriteLine($"{x.Key} : {x.Value}"));


        }
    }

    public class KeyValueObject
    {
        public char Key { get; set; }
        public bool Value { get; set; }


        public KeyValueObject(char c, bool b)
        {

            Key = c;
            Value = b;
        }
    }
}