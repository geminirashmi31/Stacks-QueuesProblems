using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementationUsingStack
{
    public class MyQueue
    {
        public Stack inputStack = new Stack();
        public Stack outputStack = new Stack();
        int temp;
        //public int size;

        public void Enqueue(int x)
        {
            inputStack.Push(x);
            //size++;
        }

        public int Dequeue()
        {
            
            if (outputStack.Count == 0)
            while(inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
            
            if(outputStack.Count > 0)
            {
                temp = (int)outputStack.Pop();
            }

            return temp;
        }
    }
}
