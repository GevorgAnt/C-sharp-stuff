using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace DataStructers
{
    class Que
    {
        object[] data = new object[1024];
        int head =0;
        int tail = 0;
        public Que()
        {

        }

        public void EnQueue(object a)
        {
            data[tail] = a;
            if (tail == data.Length)
            {
                bool empyt=false;
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == null )
                    {
                        empyt = true;
                        tail = i;
                        break;
                    }
                }
                if(!empyt)
                    Console.WriteLine("Que overflawed");

            }
            else 
            {
                tail = tail + 1;
            }
        }
        public object DelQueue()
        {
            object x = data[head];
            data[head] = null;
            if (head == data.Length)
            {
                head = 0;
            }
            else
                head++;
            return x;
        }
    }

}
