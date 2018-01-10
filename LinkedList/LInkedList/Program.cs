using System;
using System.Collections.Generic;
using System.Text;

namespace LInkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL LL = new SLL();

            Console.WriteLine("This is the Add First method");
            LL.AddFirst(1);
            LL.AddFirst(2);
            LL.AddFirst(3);
            DisplayList(LL.Head);

            Console.WriteLine("This is the Add Last method, 5 and 6 are added to the end of the list");
            LL.AddLast(5);
            LL.AddLast(6);
            DisplayList(LL.Head);

            Console.WriteLine("this is the Add before method, I have chosen to add 8 before the value of 3");
            LL.AddBefore(8, 3);
            DisplayList(LL.Head);
            Console.ReadLine();

            Console.WriteLine();

        }

        static void DisplayList(SLLNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
