using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.HashTables;

public class HashExercises
{
    public int[] Ints { get; set; } ={2,5,1,2,3,5,1,2,4};

    public int FindFirstOccurring()
    {
        var founded = new Hashtable(); 
        for (int i = 0; i < Ints.Length; i++)
        {
            if (founded.ContainsKey(Ints[i]))
            {
                return Ints[i];
            }
            founded[Ints[i]] = Ints[i];
        }

        return -1;
    }

}