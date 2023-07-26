using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace DataStructuresAndAlgorithms.LinkedLists;

public class Node
{
    // linked lists are objectified arrays
    public int Data { get; set; }
    public Node? Next  { get; set; }
    public Node? Prev  { get; set; }

    public Node(int value)
    {
        Data = value;
        Next = null;
        Prev = null;
    }
}


public class DoublyLinkedLists
{
    public Node head;
    public Node tail;
    public int length;

    public DoublyLinkedLists(int value)
    {
        head = new Node(value);
        tail = head;
        length = 1;
    }

    public DoublyLinkedLists ReverseLinkedList(DoublyLinkedLists linkedList)
    {
        if (linkedList.head.Next is null)
        {
            return linkedList;
        }

        var first = linkedList.head;
        linkedList.tail = linkedList.head;
        var second = first.Next;
        while (second is not null)
        {
            // 
            var temp = second.Next;
            second.Next = first;
            first = second;
            second = temp;

        }

        linkedList.head.Next = null;
        return linkedList;
    }

    public void AppendDoubly(int value)
    {
        Node newNode = new Node(value);
        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
        length++;
    }

    public void PrependDoubly(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
        length++;
    }


    public void InsertImplementedDoubly(int value, int index)
    {

        if (index >= length)
        {
            AppendDoubly(value);
        }
        Node newNode = new Node(value);
        // finding index we want to insert
        var nodeBeforeOurNewNode = TraverseToIndex(index - 1);
        var pointerToNodeAfterNewNode = nodeBeforeOurNewNode.Next;
        newNode.Next = pointerToNodeAfterNewNode;
        newNode.Prev = nodeBeforeOurNewNode;
        nodeBeforeOurNewNode.Next = newNode;
        pointerToNodeAfterNewNode.Prev = newNode;
        length++;

    }

    public void DeleteAtIndex(int index)
    {   // if index zero we just have to move our head
        if (index == 0)
        {
            head = head.Next;
        }
        var nodeToDelete = TraverseToIndex(index);
        var nodeBeforeOurIndex = nodeToDelete.Prev;
        var nodeAfterOurIndex = nodeToDelete.Next;

        if (nodeAfterOurIndex != null && nodeBeforeOurIndex !=null)
        {
            nodeAfterOurIndex.Prev = nodeBeforeOurIndex;
            nodeBeforeOurIndex.Next = nodeAfterOurIndex;
        }

        length--;
    }

    public Node TraverseToIndex(int index)
    {

        var counter = 0;
        var currentNode = head;
        // until we find index we want to loop through nodes
        while (counter != index)
        {
            currentNode = currentNode.Next;
            counter++;
        }

        return currentNode;
    }





    public void InsertBuildIn(int index, int value)
    {
        var linkedList = new LinkedList<int>();
        linkedList.AddFirst(new LinkedListNode<int>(10));
        linkedList.AddFirst(new LinkedListNode<int>(15));
        linkedList.AddFirst(new LinkedListNode<int>(20));

        var node = linkedList.Find(2);
        if (node is not null)
        {
            linkedList.AddAfter(node, 3);
            linkedList.AddBefore(node, 99);
        }
    }
}



public class LinkedList
{
    private Node head;
    private Node tail;
    private int length;

    public LinkedList(int value)
    {
        head = new Node(value);
        tail = head;
        length = 1;
    }

    public void Append(int value)
    {
        Node newNode = new Node(value);
        tail.Next = newNode;
        tail = newNode;
        length++;
    }

    public void Prepend(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
        length++;
    }


    public void InsertImplemented(int value, int index)     
    {

        if (index >= length)
        {
            Append(value);
        }
        Node newNode = new Node(value);
        // finding index we want to insert
        var nodeBeforeOurNewNode = TraverseToIndex(index - 1);
        var pointerToNodeAfterNewNode = nodeBeforeOurNewNode.Next;
        nodeBeforeOurNewNode.Next = newNode;
        newNode.Next = pointerToNodeAfterNewNode;
        length++;

    }

    public void DeleteAtIndex(int index)
    {   // if index zero we just have to move our head
        if (index ==0)
        {
            head = head.Next;
        }
        var nodeBeforeOurIndex = TraverseToIndex(index - 1);
        var nodeAfterOurIndex = TraverseToIndex(index + 1);
        nodeBeforeOurIndex.Next = nodeAfterOurIndex;
        length--;
    }

    public Node TraverseToIndex(int index)
    {
        
        var counter = 0;
        var currentNode = head;
        // until we find index we want to loop through nodes
        while (counter != index)    
        {
            currentNode = currentNode.Next;
            counter++;
        }

        return currentNode;
    }



    public void InsertBuildIn(int index, int value)
    {
        var linkedList = new LinkedList<int>();
        linkedList.AddFirst(new LinkedListNode<int>(10));
        linkedList.AddFirst(new LinkedListNode<int>(15));
        linkedList.AddFirst(new LinkedListNode<int>(20));

        var node = linkedList.Find(2);
        if (node is not null)
        {
            linkedList.AddAfter(node, 3);
            linkedList.AddBefore(node, 99);
        }
    }

    public Node Reverse()
    {
        //Node first = head;
        //tail = head;
        //Node second = first.Next;
        //for (int i = 0; i < length-1; i++)
        //{
        //    Node temp = second.Next;
        //    second.Next = first;
        //    first = second;
        //    second = temp;
        //}

        //head.Next = null;
        //head = first;
        Node prevNode = null;
        while (head != null)
        {
            Node nextNode = head.Next; //1
            head.Next = prevNode; //null
            prevNode = head; // 0
            head = nextNode; //1 
        }

        return prevNode;
    }
}