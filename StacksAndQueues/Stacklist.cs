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
        internal void Peek()
        {
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in top of the stack", temp.data);

        }


        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in top of stack", this.top.data);

        }
    

        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("The value popped is : {0}", this.top.data);
            this.top = this.top.next;
        }

        internal void IsEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }

    }
}

