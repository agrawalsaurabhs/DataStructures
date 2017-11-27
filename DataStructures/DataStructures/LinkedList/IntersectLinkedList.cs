using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
   public class IntersectLinkedList
    {
        public static Node IntersectLinkedListUsingRecursion(Node list1, Node list2)
        {
            while (list1 != null && list2 != null)
            {
                if (list1.Data < list2.Data)
                {
                    list1 = list1.Next;
                }
                if (list1.Data > list2.Data)
                {
                    list2 = list2.Next;
                }

                if(list1.Data == list2.Data)
                    break;
            }
            if (list1 == null || list2 == null)
            {
                return null;
            }
            Node newnode = new Node
            {
                Data = list1.Data,
                Next = IntersectLinkedListUsingRecursion(list1.Next, list2.Next)
            };
            return newnode;
            }
        }
    }
