using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructers
{
    class Linkedlist
    {
      public  ListNode head;
        public static void InsertStart(Linkedlist linkedlist,int data)
        {
            ListNode newnode = new ListNode(data);
            newnode.prew = null;
            newnode.next = linkedlist.head;
            if (linkedlist.head != null)
            {
                linkedlist.head.prew = newnode;
            }
            linkedlist.head = newnode;
        }
        public static ListNode SearchList(Linkedlist linkedlist, int data)
        {
            ListNode nd = linkedlist.head;
            while (nd != null && nd.data != data)
            {
                nd = nd.next;
            }
           
                return nd;
           
        }

        public static void RemoveNode(Linkedlist linkedlist, int data)
        {
            ListNode list = linkedlist.head;
            if (list != null && list.data == data)
            {
                linkedlist.head = list.next;
                linkedlist.head.prew = null;
                return;
            }
            ListNode listNode = Linkedlist.SearchList(linkedlist, data);
            if (listNode == null)
                return;
           // listNode.next.prew = listNode.prew.next;
            if (listNode.next != null)
            {
                listNode.next.prew = listNode.prew;
            }
            if (listNode.prew != null)
            {
                listNode.prew.next = listNode.next;
            }
        }

    }
}
