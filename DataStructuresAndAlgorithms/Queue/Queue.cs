namespace DataStructuresAndAlgorithms.Queue;

public class Queue
{
    public int MaxSize { get; set; } // sets the number of elements because this is array 
    public int[] QueueArray { get; set; } // Actual array we can implement LL 
    public int Front { get; set; } // Index to keep track of where top is it
    public int Rear { get; set; } // Index to keep track of adds
    public int NItems { get; set; } // keep track of length

    public Queue(int size)
    {
        MaxSize = size;
        QueueArray = new int[size];
        Front = 0;
        Rear = -1; // rear doesn't exist at initialization 
    }

    public void Enqueue(int item) // add
    {
        Rear++; // increment our pointer 
        QueueArray[Rear] = item; // insert at the end 
        NItems++;
    }

    public int Dequeue()
    {
        int tempFront = QueueArray[Front];
        Front++;
        if (Front == MaxSize)
        {
            Front = 0;
        }
        NItems--;
        return tempFront;
    }

    public int Peek()
    {
        return QueueArray[Front];
    }

}