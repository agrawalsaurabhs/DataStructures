using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public static class LinkedListRunner
    {
        public static void Run()
        {
            MyLinkedList myLinkedList1 = new MyLinkedList();
            myLinkedList1.Add(1);
            myLinkedList1.Add(3);
            myLinkedList1.Add(4);
            myLinkedList1.Add(6);
            myLinkedList1.Add(8);
            myLinkedList1.Add(10);

            MyLinkedList myLinkedList2 = new MyLinkedList();
            myLinkedList2.Add(1);
            myLinkedList2.Add(3);
            myLinkedList2.Add(4);
            myLinkedList2.Add(6);
            myLinkedList2.Add(8);
            myLinkedList2.Add(10);

            Console.WriteLine(IdentialLinkedList.IsIdentical(myLinkedList1.Head, myLinkedList2.Head) ? "Yes" : "No");
            

            //MyLinkedList intersected = new MyLinkedList();
            //intersected.Head = new Node() { };
            //intersected.Head =IntersectLinkedList.IntersectLinkedListUsingRecursion(myLinkedList1.Head, myLinkedList2.Head);
            //intersected.Print();

            //MyLinkedList mergeList = new MyLinkedList();
            //mergeList.Head = new Node() {};
            //mergeList.Head = MergeLinkedList.MergeLinkedListUsingRecursion(myLinkedList1.Head, myLinkedList2.Head.Next);
            //mergeList.Print();



            //myLinkedList1.Reverse();

            //myLinkedList1.Print();

            //myLinkedList.SearchElementRecursive(100);
            //myLinkedList.SearchElementRecursive(10);
            //myLinkedList.SearchElementRecursive(30);

            //myLinkedList.LengthLinkedListIterative();
            //myLinkedList.LengthLinkedListRecursive();
            //Console.WriteLine("Delete node at a given position");
            //myLinkedList.DeleteNodeAtGivenPosition(0);
            //myLinkedList.Print();
            //myLinkedList.DeleteNodeAtGivenPosition(4);
            //myLinkedList.Print();
            //myLinkedList.DeleteNodeAtGivenPosition(2);
            //myLinkedList.Print();

            //myLinkedList.Remove(10);
            //myLinkedList.Print();
            //myLinkedList.Remove(10);
            //myLinkedList.Print();
            //myLinkedList.Remove(20);
            //myLinkedList.Print();
            //myLinkedList.Remove(20);
            //myLinkedList.Print();
            //myLinkedList.Remove(30);
            //myLinkedList.Print();
            //myLinkedList.Remove(30);
            //myLinkedList.Print();
            //myLinkedList.Remove(30);
            //myLinkedList.Print();
            //myLinkedList.LengthLinkedListIterative();
            //myLinkedList.LengthLinkedListRecursive();
        }
    }
}
