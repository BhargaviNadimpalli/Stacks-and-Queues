using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and queues progrmas");
            Stacklist list = new Stacklist();
            list.push(70);
            list.push(30);
            list.push(56);
            list.Display();

        }
    }
}
