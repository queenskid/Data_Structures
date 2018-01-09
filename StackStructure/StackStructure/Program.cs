using System;

namespace StackStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            StackNode A1 = new StackNode(1);
            Stacks PS = new Stacks(A1);
            Console.WriteLine("called new StackNodeA1");
            Console.WriteLine("Head value is: " + PS.Head.Value);
            Console.ReadLine();

            StackNode A2 = new StackNode(2);
            PS.PushStack(A2);
            Console.WriteLine("Called AddLast(A2)");
            Console.WriteLine("Head value is: " + PS.Head.Value);
            Console.WriteLine("Second Item Value: " + PS.Head.Next.Value);
            Console.ReadLine();

            StackNode A3 = new StackNode(3);
            PS.PushStack(A3);
            Console.WriteLine("Called AddFirst(A3)");
            Console.WriteLine("Head value is: " + PS.Head.Value);
            Console.WriteLine("Second Item Value: " + PS.Head.Next.Value);
            Console.WriteLine("Third Item Value: " + PS.Head.Next.Next.Value);
            Console.ReadLine();

            PS.PopStack(A3);
            Console.WriteLine("Called Remove(A3)");
            Console.WriteLine("Head value is: " + PS.Head.Value);
            Console.WriteLine("Second Item Value: " + PS.Head.Next.Value);
            Console.WriteLine("Third Item Value: " + PS.Head.Next.Next.Value);
            Console.WriteLine("Fourth Item Value: " + PS.Head.Next.Next.Next.Value);
            Console.ReadLine();
        }
        //Console.ReadLine();
    }
}
