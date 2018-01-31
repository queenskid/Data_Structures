using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceNodes
{
    class Tree
    {
        public Node Root;

        public void SwapWithBreadth(int a, int b)
        {
            Queue<Node> q = new Queue<Node>();
            Node NodeSwapOne = null;
            Node NodeSwapTwo = null;
            q.Enqueue(Root);
            while (q.Count > 0)
            {
                Node temp = q.Dequeue();
                if (temp.Left == null && temp.Right == null)
                {
                    if (temp.Value == a) NodeSwapOne = temp;
                    if (temp.Value == b) NodeSwapTwo = temp;
                }
                if (NodeSwapOne != null && NodeSwapTwo != null)
                {
                    Node actualSwap = NodeSwapOne;
                    NodeSwapOne = NodeSwapTwo;
                    NodeSwapTwo = actualSwap;
                    return;
                }
                if (temp.Left != null) q.Enqueue(temp.Left);
                if (temp.Right != null) q.Enqueue(temp.Right);
            }
        }

        public void InOrder(Node root)
        {
            if (root.Left != null)
            {
                InOrder(root.Left);
            }
            Console.WriteLine(root.Value);

            if (root.Right != null)
            {
                InOrder(root.Right);
            }
        }
    }


}
