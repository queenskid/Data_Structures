using System;
using System.Collections.Generic;
using System.Text;

namespace StackStructure
{
    class Stacks
    {
        public StackNode Head { get; set; }
        private int ListSize { get; set; }

        public Stacks(StackNode node)
        {
            Head = node;
            ListSize = 1;
        }

        public void PushStack(StackNode newStack)
        {
            newStack.Next = Head;
            Head = newStack;
            ListSize++;
        }

        public void PopStack(StackNode RemoveTop)
        {
            StackNode Current = Head;
            while (Current.Next != RemoveTop)
            {
                Current = Current.Next;
            }
            Current.Next = Current.Next.Next;
            RemoveTop.Next = null;
            ListSize--;
        }


    }
}
