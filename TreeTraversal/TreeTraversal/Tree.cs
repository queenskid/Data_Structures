using System;
using System.Collections.Generic;
using System.Text;

namespace TreeTraversal
{
    class Tree
    {
        public Node Root { get; set; }

        public Tree()
        {
            Root = null;
        }

        public Node ReturnRoot()
        {
            return Root;
        }


        public object AddFirst(object Value)
        {
            if (Root == null)
            {
                Root = new Node(Value);
                return Root.Value;
            }
            else
            {
                Console.WriteLine("Tree already has a root");
                return null;
            }
        }


        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.Left);
                Console.Write(Root.Value + " ");
                Inorder(Root.Right);
            }
        }

        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Value + " ");
                Preorder(Root.Left);
                Preorder(Root.Right);
            }
        }


        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.Left);
                Postorder(Root.Right);
                Console.Write(Root.Value + " ");
            }
        }
    }
}

