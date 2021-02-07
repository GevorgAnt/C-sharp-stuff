using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructers
{
    class BinaryNode
    {
        internal int root;
        internal BinaryNode left;
        internal BinaryNode right;
        public BinaryNode(int kay)
        {
            root = kay;
            left = right = null;
        }
    }
}
