﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLL
{
    class Methods
    {
        public Node Head { get; set; }
        private int Counter { get; set; }

        public Methods(Node node)
        {
            Head = node;
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
                Node Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = newNode;
                Current.Next.Prev = Current;
            }
            Counter++;
        }


        // adding a node before list, using a target node to identify position in list. 
        public void AddBefore(Node targetNode, Node newNode)
        {
            if (Head == null) return;
            Node Current = Head;
            while (Current.Next != targetNode)
            {
                if (Current.Next != null)
                {
                    Current = Current.Next;
                }
                else
                    return;
            }

            newNode.Next = Current.Next;
            Current.Next.Prev = newNode;
            Current.Next = newNode;
            newNode.Prev = Current;
            Counter++;
        }

        // add a node after a target node is identified. 
        public void AddAfter(Node targetNode, Node newNode)
        {
            if (Head == null) return;
            Node Current = Head;

            while (Current != targetNode)
            {
                if (Current.Next != null)
                {
                    Current = Current.Next;
                }
                else
                    return;
            }
            newNode.Next = Current.Next;
            Current.Next.Prev = newNode;
            Current.Next = newNode;
            newNode.Prev = Current;
            Counter++;
        }

        // this method is the most difficult to understand for me, I used a lot of different code snippets from stackoverflow to get this. 
        public void Remove(Node targetNode)
        {
            if (Head == null)
                return;
            Node Current = Head;

            while (Current != targetNode)
            {
                if (Current.Next != null)
                {
                    Current = Current.Next;
                }
                else
                    return;
            }

            if (Counter == 1)
                Head = null;

            else if (Current.Prev == null)
            {
                Head = Current.Next;
                Current.Next.Prev = null;
            }
            else if (Current.Next == null)
            {
                Current.Prev.Next = null;
            }
            else
            {
                Current.Prev.Next = Current.Next;
                Current.Next.Prev = Current.Prev;
            }
            Current = null;
            Counter--;
        }
    }
}