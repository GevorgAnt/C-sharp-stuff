using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DataStructers
{
    class BinaryTree
    {
      public  BinaryNode root;
        public BinaryTree(int key)
        {
            root = new BinaryNode(key);
        }
        public BinaryTree()
        {
            root = null;
        }

        public static void TreeInsert(BinaryTree binaryTree, int z)
        {
            BinaryNode newnode = new BinaryNode(z);
            BinaryNode y = null;
            BinaryNode x = binaryTree.root;
            while (x != null)
            {
                y = x;
                if (newnode.root < x.root)
                    x = x.left;
                else
                    x = x.right;
            }

            if (y == null)
                binaryTree.root = newnode;
            else if (z < y.root)
                y.left = newnode;
            else
                y.right = newnode;
        }

        public  BinaryNode Searchtree(BinaryNode node,int k)
        {

            if (node == null || node.root == k)
                return node;
            
            if (k < node.root)
                return Searchtree(node.left, k);
            else
                return Searchtree(node.right, k);


        }















    }
}
