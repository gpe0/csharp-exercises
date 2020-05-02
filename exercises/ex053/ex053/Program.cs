using System;
using System.Collections.Generic;

namespace ex053
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections | Stacks | Last In, First Out(LIFO) | insert - push | delete - pop
            Stack<int> stack = new Stack<int>();
            stack.Push(59);
            stack.Push(8);
            stack.Push(100);
            stack.Push(2);
            Console.WriteLine(stack.Count);
            stack.Pop(); //This method popped the "2", because it was the last one.
            foreach(int n in stack)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
            //Collections | Queues | First In, First Out(FIFO) | insert - enqueue | delete - dequeue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(8);
            queue.Enqueue(100);
            queue.Enqueue(70);
            Console.WriteLine(queue.Count);
            queue.Dequeue(); // Now we dequeued the "4", because it is the first one.
            foreach (int n in queue)
            {
                Console.Write("{0} ", n);
            }
        }
    }
}
