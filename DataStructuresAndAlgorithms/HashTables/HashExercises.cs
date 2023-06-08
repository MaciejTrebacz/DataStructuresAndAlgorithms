using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.HashTables;

public class HashExercises
{
    public int[] Ints { get; set; } ={2,5,1,2,3,5,1,2,4};

    public int? FindFirstOccurring()
    {
        var founded = new Hashtable(); 
        foreach (var number in Ints)
        {
            if (founded.ContainsKey(number))
            {
                return number;
            }
            founded[number] = number;
        }

        return null;
    }

}