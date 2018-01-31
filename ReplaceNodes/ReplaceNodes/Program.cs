using System;

namespace ReplaceNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree testTree = new Tree
            {
                Root = new Node
                {
                    Value = 2,
                    Left = new Node
                    {
                        Value = 4,
                        Left = new Node { Value = 3 },
                        Right = new Node { Value = 10 }
                    },
                    Right = new Node
                    {
                        Value = 9,
                        Right = new Node { Value = 1 },
                        Left = new Node { Value = 5 }
                    }
                }
            };

            Console.WriteLine("Pre Swap");
            testTree.InOrder(testTree.Root);

            testTree.SwapWithBreadth(1, 3);

            Console.WriteLine("Post Swap");
            testTree.InOrder(testTree.Root);

            Console.ReadLine();
        }
    }
}
