using System;

namespace StacksAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Testing Stacks!");
            Console.WriteLine();
            Console.WriteLine("Pushing 1 into S1");
            Stacks S1 = new Stacks(1);
            Console.WriteLine("Push 2 into stack");
            S1.Push(2);
            Console.WriteLine("Calling Peek(): " + S1.Peek());
            Console.WriteLine("Calling Pop()");
            S1.Pop();
            Console.WriteLine("Calling Peek(): " + S1.Peek());

            Console.ReadLine();
        }
    }
}
