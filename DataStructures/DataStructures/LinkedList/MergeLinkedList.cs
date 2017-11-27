using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class MergeLinkedList
    {
        public static Node MergeLinkedListUsingRecursion(Node list1, Node list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }
            if (list1.Data <= list2.Data)
            {
                Node temp = list1;
                list1 = list1.Next;
                temp.Next = MergeLinkedListUsingRecursion(list1, list2);
                return temp;
            }
            else
            {
                Node temp = list2;
                list2 = list2.Next;
                temp.Next = MergeLinkedListUsingRecursion(list1, list2);
                return temp;
            }
        }
    }
}
