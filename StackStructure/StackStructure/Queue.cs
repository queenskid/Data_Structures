using System;
using System.Collections.Generic;
using System.Text;

namespace StackStructure
{
    class Queue

    {
        public StackNode Head { get; set; }
        public StackNode Runner { get; set; }

        public void NQ(int Val)
        {
            Head = new StackNode { Value = Val, Next = Head };
        }

        public StackNode Peek()
        {
            Runner = Head;
            while (Runner.Next != null)
            {
                Runner = Runner.Next;
            }
            return Runner;
        }

        public void DQ()
        {
            Runner = Head;
            while (Runner.Next.Next != null)
            {
                Runner = Runner.Next;
            }
            Runner.Next = null;
        }
    }
}