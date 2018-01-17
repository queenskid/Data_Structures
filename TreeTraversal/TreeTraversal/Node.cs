using System;
using System.Collections.Generic;
using System.Text;

namespace TreeTraversal
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
        public void display()
        {
            Console.Write("(");
            Console.Write(value);
            Console.Write(")");

        }
    }
}
