
using System.Xml.Schema;

public class StackLL
{
    public Node Top { get; set; }
    public Node Bottom { get; set; }
    public int Length { get; set; }


    public StackLL(int value)
    {
        var newNode = new Node(value);
        Bottom = newNode;
        Top = newNode;
        Length = 1;
    }

    public void Push(int value)
    {
        Length++;
        var newNode = new Node(value);
        Node holdingPointer = Top;
        Top = newNode;
        Top.Next = holdingPointer;
    }

    public Node Peek()
    {
        return Top;
    }

    public Node Pop()
    {
        var topNode = Top;
        Top = topNode.Next;
        Length--;
        return topNode;
    }
}


public class Node
{
    // linked lists are objectified arrays
    public int Data { get; set; }
    public Node? Next { get; set; }

    public Node(int value)
    {
        Data = value;
        Next = null;
    }
}