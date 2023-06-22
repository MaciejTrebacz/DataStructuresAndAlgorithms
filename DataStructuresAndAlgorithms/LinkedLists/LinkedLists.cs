namespace DataStructuresAndAlgorithms.LinkedLists;

public class LinkedLists2
{
    public Node First { get; set; }

    public void InsertFirst(int data)
    {
        // create the node

        Node newNode = new Node(10);
        // put the data
        newNode.Data = data;
        // put the old node in next
        newNode.Next = First;
        //make the first new node
        First = newNode;

    }
}