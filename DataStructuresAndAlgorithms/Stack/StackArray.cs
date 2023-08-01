using System;
using System.Linq;

namespace DataStructuresAndAlgorithms.Stack;

public class StackArray
{


    public int[] Stack { get; set; }
    public int Top { get; set; }
    public int MaxSize { get; set; }


    public StackArray(int maxSize)
    {
        MaxSize = maxSize;
        Stack = new int[MaxSize];
        Top = -1;
    }

    public string? Push(int value)
    {
        if (Top++ > MaxSize) return "too big";
        Stack[Top++] = value;
        return null;
    }

    public int Peek()
    {
        return Stack[Top];
    }

    public int Pop()
    {
        var result = Stack[Top];
        Top--;
        return result;
    }
}

