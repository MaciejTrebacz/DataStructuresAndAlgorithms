using System;
using System.Xml;

namespace DataStructuresAndAlgorithms.LinkedLists;

public class Node
{
    // linked lists are objectified arrays
    public int Data { get; set; }
    public Node? Next  { get; set; }

    public void DisplayNode()
    {
        Console.WriteLine(Data);
    }

    public void ImplementingNodes()
    {
        Node nodeA = new Node();
        nodeA.Data = 11111;

        Node nodeB = new Node();
        nodeB.Data = 22222;

        Node nodeC = new Node();
        nodeC.Data = 33333;

        Node nodeD = new Node();
        nodeD.Data = 44444;

        //pointing to the next object
        nodeA.Next = nodeB;
        nodeB.Next = nodeC;
        nodeC.Next = nodeD;
        InsertAtTheBeggining(3);

        void InsertAtTheBeggining(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = nodeA;

        }

    }


}