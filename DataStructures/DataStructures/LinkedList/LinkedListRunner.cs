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
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add(10);
            myLinkedList.Add(20);
            myLinkedList.Add(30);
            myLinkedList.Add(10);
            myLinkedList.Add(20);
            myLinkedList.Add(30);
            myLinkedList.Print();
            myLinkedList.Remove(10);
            myLinkedList.Print();
            myLinkedList.Remove(10);
            myLinkedList.Print();
            myLinkedList.Remove(20);
            myLinkedList.Print();
            myLinkedList.Remove(20);
            myLinkedList.Print();
            myLinkedList.Remove(30);
            myLinkedList.Print();
            myLinkedList.Remove(30);
            myLinkedList.Print();
            myLinkedList.Remove(30);
            myLinkedList.Print();
        }
    }
}
