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
            Oak.root = new Node();
            Oak.root.value = 1;
            Oak.root.left.value = 2;
            Oak.root.left.left.value = 4;
            Oak.root.left.right.value = 5;
            Oak.root.right.value = 3;



            //Oak.Insert(1);
            //Oak.Insert(2);
            //Oak.Insert(3);
            //Oak.Insert(4);
            //Oak.Insert(5);

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
