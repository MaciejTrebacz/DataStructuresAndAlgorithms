using System.Security.AccessControl;

namespace DataStructuresAndAlgorithms.Queue;

public class QueueLL
{
    public Node First { get; set; }
    public Node Last { get; set; }
    public int Length { get; set; }

    public QueueLL()
    {
        
    }

    public Node Peek()
    {
        return First;
    }

    public void Enqueue(int value)
    {
        var newNode = new Node(value);

        if (Length == 0)
        {
            Last = newNode;
            First = newNode;
        }
        else
        {
            Last.Next = newNode;
            Last = newNode;
        }
        Length++;
    }

    public void Dequeue()
    {
        First = First.Next;
        Length--;
    }
}