using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueue
{
    class Stacks
    {
        public Node Head { get; set; }

        public Stacks(int n)
        {
            Head = new Node(n);
        }
    }
}
