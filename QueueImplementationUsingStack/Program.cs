using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementationUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();
            queue.Enqueue(4);
            queue.Enqueue(8);
            queue.Enqueue(9);
            Console.Write(queue.Dequeue()+"");
            Console.Write(queue.Dequeue()+"");
            Console.Write(queue.Dequeue()+"");
            Console.ReadKey();
        }
    }
}
