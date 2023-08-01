namespace DataStructuresAndAlgorithms.Stack;
public class Stack
{
    public int MaxSize { get; set; } // Array stacks you need a maxsize to init array
    public string[] StackArray { get; set; }
    public int Top { get; set; } // where top is located

    public Stack(int value)
    {
        MaxSize = value;
        StackArray = new string[MaxSize];// creating array with size
        Top = -1; // we give the top -1 because array is zero index, if we don't it will skip first element
    }

    public void Push(string item)
    {
        Top++;
        StackArray[Top] = item;
    }

    public string Pop()
    {
        int oldTop = Top; // this is placeholder to return thing we deleting
        Top--; // decreameant for the new top
        return StackArray[oldTop];
    }

    public string Peek() // peek means access First
    {
        return StackArray[Top];
    }

    public bool IsEmpty()
    {
        return Top == 0;
    }

    public bool IsFull()
    {
        return MaxSize-1 == Top;
    }

}