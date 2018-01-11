using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue
{
    class Queue
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public Queue(int n)
        {
            Head = new Node(n);
            Tail = Head;
        }
    }
}
