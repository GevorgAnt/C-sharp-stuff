using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DataStructers
{
    class Stack
    {
        private static object[] data = new object[1024];
        private static int pointer = 0;

        public Stack()
        {

        }

        public void Insert(object a)
        {
            if (pointer > 1024)
                Console.WriteLine("Stack overflow");
            else
            {
                data[pointer] = a;
                pointer++;
            }
        }

        public object Push()
        {
            if (pointer != 0)
            {
                pointer--;
                object ob = data[pointer];
                
                return ob;
                
            }
            else
                return "Underflow";

        }
    }
}
