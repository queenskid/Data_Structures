using System;
using System.Linq;
using BreadthFirst;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Concurrent;
namespace BreadthFirst
{
    public class Node
    {
        public Node left;
        public Node right;
        public string value;

        public Node(string value, Node left, Node right)
        {
            this.value = value;
            this.left = left;
            this.right = right;

        }

        public Node(string value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }

   
}
