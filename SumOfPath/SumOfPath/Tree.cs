using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfPath
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
    }
}
