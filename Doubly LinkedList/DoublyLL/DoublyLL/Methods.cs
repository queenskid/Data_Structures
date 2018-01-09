using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLL
{
    class Methods
    {
        public Node Head { get; set; }
        public Node Runner { get; set; }
        private int Counter { get; set; }

        public Methods(object value)
        {
            //Node node = new Node { Value = value, Previous = null, Next = null}:
            Head = node;
            Runner = Head;
            Counter = 1;
        }

        //need to create methods to add first, add last, add before and add after.

        //this method creates the first node of the list.
        public void AddFirst(Node newNode)
        {
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                Head.Next.Prev = Head;
            }
            Counter++;
        }

        // adding a node to end of list, increasing list by 2
        public void AddLast(Node newNode)
        {
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node Runner = Head;
                while (Runner.Next != null)
                {
                    Runner = Runner.Next;
                }
                Runner.Next = newNode;
                Runner.Next.Prev = Runner;
            }
            Counter++;
        }


        // adding a node before list, using a target node to identify position in list. 
        public void AddBefore(Node targetNode, Node newNode)
        {
            if (Head == null) return;
            Node Runner = Head;
            while (Runner.Next != targetNode)
            {
                if (Runner.Next != null)
                {
                    Runner = Runner.Next;
                }
                else
                    return;
            }

            newNode.Next = Runner.Next;
            Runner.Next.Prev = newNode;
            Runner.Next = newNode;
            newNode.Prev = Runner;
            Counter++;
        }

        // add a node after a target node is identified. 
        public void AddAfter(Node targetNode, Node newNode)
        {
            if (Head == null) return;
            Node Runner = Head;

            while (Runner != targetNode)
            {
                if (Runner.Next != null)
                {
                    Runner = Runner.Next;
                }
                else
                    return;
            }
            newNode.Next = Runner.Next;
            Runner.Next.Prev = newNode;
            Runner.Next = newNode;
            newNode.Prev = Runner;
            Counter++;
        }

        // this method is the most difficult to understand for me, I used a lot of different code snippets from stackoverflow to get this. 
        public void Remove(Node targetNode)
        {
            if (Head == null)
                return;
            Node Runner = Head;

            while (Runner != targetNode)
            {
                if (Runner.Next != null)
                {
                    Runner = Runner.Next;
                }
                else
                    return;
            }

            if (Counter == 1)
                Head = null;

            else if (Runner.Prev == null)
            {
                Head = Runner.Next;
                Runner.Next.Prev = null;
            }
            else if (Runner.Next == null)
            {
                Runner.Prev.Next = null;
            }
            else
            {
                Runner.Prev.Next = Runner.Next;
                Runner.Next.Prev = Runner.Prev;
            }
            Runner = null;
            Counter--;
        }
    }
}