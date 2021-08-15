using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and queues progrmas");
            QueueList list = new QueueList();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();


            list.Dequeue();
            list.Display();
            list.IsEmpty();



        }
    }
}
