using System;
using System.Collections.Generic;
using System.Text;

namespace StackStructure
{
    public class StackNode
    {
        public int Value { get; set; }
        internal StackNode Next { get; set; }


        public StackNode(int value)
        {
            Value = value;
        }
    }
}
