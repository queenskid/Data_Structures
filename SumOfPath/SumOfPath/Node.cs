﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfPath
{
    class Node
    {
        public object Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(object data)
        {
            Value = data;
        }
    }
}
