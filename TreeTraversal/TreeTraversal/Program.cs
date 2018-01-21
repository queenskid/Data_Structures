using System;


namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            
            Tree Oak = new Tree();
            Oak.AddFirst(7);
            Oak.Root.Left = new Node(2);
            Oak.Root.Left.Left = new Node(4);
            Oak.Root.Left.Right = new Node(5);
            Oak.Root.Right = new Node(3);

            Console.WriteLine("Inorder Traversal");
            Oak.Inorder(Oak.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();

            Console.WriteLine("Preorder Traversal");
            Oak.Preorder(Oak.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();

            Console.WriteLine("Postorder Traversal");
            Oak.Postorder(Oak.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();


        }
    }
}
