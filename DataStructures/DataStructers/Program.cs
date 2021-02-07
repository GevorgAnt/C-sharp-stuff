using Microsoft.VisualBasic.CompilerServices;
using System;

namespace DataStructers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            /* mystack.Insert(105);
             mystack.Insert(32);
             mystack.Insert("alala");
             mystack.Insert(0.75);
             object res = mystack.Push();
             Console.WriteLine(res);
              res = mystack.Push();
             Console.WriteLine(res);*/
            //Que que = new Que();

            //que.EnQueue(105);
            //que.EnQueue(36);
            //que.EnQueue(8);
            //que.EnQueue(9);

            //Console.WriteLine(que.DelQueue());
            //Console.WriteLine(que.DelQueue());

            // Linkedlist linkedlist = new Linkedlist();
            // Linkedlist.InsertStart(linkedlist, 10);
            // Linkedlist.InsertStart(linkedlist, 15);
            // Linkedlist.InsertStart(linkedlist, 36);

            //// Console.WriteLine(Linkedlist.SearchList(linkedlist,15).data);
            // Console.WriteLine(Linkedlist.SearchList(linkedlist, 155));
            // Console.WriteLine(Linkedlist.SearchList(linkedlist, 15));
            // //Linkedlist.RemoveNode(linkedlist, 15);
            // Linkedlist.RemoveNode(linkedlist, 36);

            // BinaryTree binaryTree = new BinaryTree();
            //BinaryTree.TreeInsert(binaryTree, 10);
            //BinaryTree.TreeInsert(binaryTree, 8);
            //BinaryTree.TreeInsert(binaryTree, 9);
            //BinaryTree.TreeInsert(binaryTree, 101);
            //BinaryTree.TreeInsert(binaryTree, 3);
            //BinaryTree.TreeInsert(binaryTree, 2);
            //Console.WriteLine(binaryTree.Searchtree(binaryTree.root, 101)); 

            Linkedlist linkedlist = new Linkedlist();
           // Linkedlist.InsertStart(linkedlist, 45);
            //Linkedlist.InsertStart(linkedlist, 41);
          //  Linkedlist.InsertStart(linkedlist, 4);

            Linkedlist.InsertStart(linkedlist, 3);
            Linkedlist.InsertStart(linkedlist, 2);
            Linkedlist.InsertStart(linkedlist, 1);
            sortedInsert(linkedlist.head, 4);
        }
        static ListNode sortedInsert(ListNode head, int data)
        {
            ListNode node = head;
            ListNode newnode = new ListNode(data);

            while (data > head.data)
            {
                if (head.next == null)
                {
                    newnode.prew = head;

                    head.next = newnode;
                    break;
                }
                head = head.next;
            }


            if (head.prew == null)
            {
                head.prew = newnode;
                newnode.next = head;
                return newnode;
            }
            else
            {
                head = head.prew;
                ListNode others = head.next;
                others.prew = newnode;
                newnode.prew = head;
                head.next = newnode;
                newnode.next = others;
            }
               
            
            //ListNode others = head;

            //newnode.next = others;
            
            
           // head = newnode;
            


            return node;
        }
    }
}
