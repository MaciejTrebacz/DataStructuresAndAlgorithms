using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Arrays
{
    public class ArrayImplementation
    {
        public int Length { get; set; } = 0;
        public List<object> Values { get; set; } = new List<object>();

        public object Get(int index)
        {
            return Values[index];
        }

        public int Push(object item )
        {
            Values.Add( item );
            Length++;
            return Length;
        }

        public object Pop()
        {
            var lastItem = Values[Length - 1];
            Values.RemoveAt( Length -1 );
            Length--;
            return lastItem;
        }

        public object Delete(int index)
        {
            var item = Values[index];
            ShiftItems(index);
            Values.RemoveAt(Length - 1);

            return item;
        }

        public void ShiftItems(int index)
        {
            for (int i = index; i < Length -1; i++)
            {
                //shifting
                Values[i] = Values[i+1];

            }
        }
    }
}