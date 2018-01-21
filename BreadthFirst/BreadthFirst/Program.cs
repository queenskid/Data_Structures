using System;
using System.Linq;
using BreadthFirst;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Concurrent;


namespace BreadthFirst
{
    partial class Program
    {
        static Node sample_tree()
        {
            Node root = new Node("A",
            new Node("B",
            new Node("C"),
            new Node("D")),
            new Node("E",
            new Node("F"), null));

            return root;
        }

        static void Main(string[] args)
        {
            Node tree = sample_tree();
            Console.WriteLine("BreadthFirst Traversal"); Bfs_traversal(tree);
            Console.ReadLine();
        }
    }
}
