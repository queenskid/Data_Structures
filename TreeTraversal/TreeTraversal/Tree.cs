using System;
using System.Collections.Generic;
using System.Text;

namespace TreeTraversal
{
    class Tree
    {
        public Node root { get; set; }

        public Tree()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return root;
        }


        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.value = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.value)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        

        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.left);
                Console.Write(Root.value + " ");
                Inorder(Root.right);
            }
        }

        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.value + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }


        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.left);
                Postorder(Root.right);
                Console.Write(Root.value + " ");
            }
        }
    }
}

