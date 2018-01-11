using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue
{
    class Stacks
    {
        public Node Head { get; private set; }

        public Stacks(int n)
        {
            Head = new Node(n);
        }

        public void Push(int n)
        {
            Node node = new Node(n);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        public int Peek() => Head.Value;
        public void Pop() => Head = Head?.Next;


    }
}
