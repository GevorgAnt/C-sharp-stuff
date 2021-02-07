using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructers
{
    class ListNode
    {
       internal int data;
       internal ListNode next;
       internal ListNode prew;

        public ListNode(int data)
        {
            this.data = data;
            next = null;
            prew = null;
        }
    }
}
