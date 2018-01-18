using System;
using System.Collections.Generic;
using System.Text;

namespace QandATree
{
    class Node
    {
        public string Question { get; set; }

        public string Answer { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

    }
}
