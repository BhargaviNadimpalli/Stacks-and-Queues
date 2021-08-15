using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Stacklist
    {
        private Node top;
        public Stacklist()
        {
            this.top = null;
        }
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;

            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to stack ", value);
        }
         internal void Display()
        {
            if (this.top == null)
                Console.WriteLine("list is empty.");
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine("Data : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
