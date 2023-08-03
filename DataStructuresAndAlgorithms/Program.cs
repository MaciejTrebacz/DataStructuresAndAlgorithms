using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAndAlgorithms.Arrays;
using DataStructuresAndAlgorithms.BigO;
using DataStructuresAndAlgorithms.BinarySearchTree;
using DataStructuresAndAlgorithms.CodingProblems;
using DataStructuresAndAlgorithms.HashTables;
using DataStructuresAndAlgorithms.LinkedLists;
using DataStructuresAndAlgorithms.SpaceComplexity;
using DataStructuresAndAlgorithms.Stack;

internal class Program
    {
        static void Main(string[] args)
        {
        //    // O(n)
        //    var bigO = new OeN();
        //    //bigO.findArray();

        //    // O(1)
        //    var oOne = new O_1_();
        //    //oOne.logBoxes();


        //    // O(n^2)
        //    var oEnX2 = new O_n_2_();
        //    //oEnX2.loopThrough();

        //    // space complexity
        //    int[] num = { 1, 2, 3, 4, 5, 6 };
        //    var space = new SpaceComplexity();
        //    //space.boooo(num);

        //    // coding problem 
        //    var problem = new InterviewQuestion();

        //    //problem.FindCommon2();

        //    var arrayIntroduction = new ArrayIntroduction();
        //    //arrayIntroduction.AddAtTheEndOfArray();
        //    //arrayIntroduction.InsertAtTheStartOfTheArray();
        //    //arrayIntroduction.InsertAnywhereInArray();


        //    var arrayImplementation = new ArrayImplementation();
        //    //arrayImplementation.Push("a");
        //    //arrayImplementation.Push("b");
        //    //arrayImplementation.Push("c");
        //    //arrayImplementation.Push("d");
        //    //arrayImplementation.Push("e");
        //    //arrayImplementation.Push("f");

        //    //arrayImplementation.Delete(5);
        //    //arrayImplementation.Values.ForEach(Console.WriteLine);

        //    var arrayExercise = new ArrayExercises();
        ////Console.WriteLine(arrayExercise.ReverseString2("Siema Maciej"));
        ////var a = new int[] { 10, 2, 30 };
        ////var b = new int[] { 4, 5, 6 };
        ////var c = arrayExercise.MergeSortedArray3(a, b);

        ////foreach (var i in c)
        ////{
        ////    Console.WriteLine(i);
        ////}

        ////arrayExercise.TwoSum(new[] { 2, 5, 5, 11 }, 10);
        ////var a = arrayExercise.SubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        ////Console.WriteLine(a);

        // //int[] nums = new[] { 0, 1, 0, 3, 12 };
        // //var a = arrayExercise.MoveZeroes(nums);
        // //foreach (var i in a)
        // //{
        // //    Console.WriteLine(i);
        // //}

        //// var hashIntro = new HashTablesIntroduction();
        //// hashIntro.Set("Maciej","884-911-133");
        //// hashIntro.Set("Teddy","111-222-333");
        //// hashIntro.Set("Pam","000-000-0004");
        //// hashIntro.Set("Sara","4258349873498");
        //// hashIntro.Set("XXX","1");

        //// Console.WriteLine(hashIntro.Get("Maciej"));
        //// Console.WriteLine(hashIntro.Get("Teddy"));
        //// Console.WriteLine(hashIntro.Get("Pam"));
        //// Console.WriteLine(hashIntro.Get("Sara"));
        //// Console.WriteLine(hashIntro.Get("XXX"));

        ////hashIntro.Keys();


        ////HashExercises hashExercises = new HashExercises();
        ////Console.WriteLine(hashExercises.FindFirstOccurring());

        //DoublyLinkedLists doublyLinkedLists = new DoublyLinkedLists(0);
        //doublyLinkedLists.AppendDoubly(1);
        //doublyLinkedLists.AppendDoubly(2);
        //doublyLinkedLists.AppendDoubly(3);
        //doublyLinkedLists.AppendDoubly(4);
        //doublyLinkedLists.AppendDoubly(5);
        //var reversed = doublyLinkedLists.ReverseLinkedList(doublyLinkedLists);
        ////doublyLinkedLists.PrependDoubly(9999);
        ////doublyLinkedLists.InsertImplementedDoubly(1111,2);
        //LinkedList linkedList = new LinkedList(0);
        //linkedList.Append(1);
        //linkedList.Append(2);
        //linkedList.Append(3);
        //linkedList.Append(4);
        //linkedList.Append(5);
        //linkedList.Reverse();



        //Stack stack = new Stack(10);

        //for (int i = 0; i < 3; i++)
        //{
        //    stack.Push("Squirtle");
        //    stack.Push("Pikachu");
        //    stack.Push("Bulbazaur");
        //}

        //stack.Pop();
        //stack.Peek();

        //while (!stack.IsEmpty())
        //{
        //    var value = stack.Pop();
        //    Console.WriteLine(value);
        //}

        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(100,"Jim" );
        bst.Insert(200,"Micheal" );
        bst.Insert(300,"Pam" );
        bst.Insert(10,"Kevin" );


        Console.ReadLine();

    }
}

