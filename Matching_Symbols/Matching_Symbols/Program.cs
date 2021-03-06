﻿using System;
using System.Collections.Generic;

namespace Matching_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            Console.WriteLine("(){}(){}");
            if (Challenge("(){}(){}")) Console.WriteLine("True!");
            else Console.WriteLine("False!");
            Console.WriteLine();

            Console.WriteLine("({(({}))})");
            if (Challenge("({(({}))})")) Console.WriteLine("True!");
            else Console.WriteLine("False!");
            Console.WriteLine();

            Console.WriteLine("{{({)})}}");
            if (Challenge("{{({)})}}")) Console.WriteLine("True!");
            else Console.WriteLine("False!");
            Console.WriteLine();

            Console.ReadLine();
        }

        public static bool Challenge(string l)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < l.Length; i++)
            {
                if (stack.Count != 0 && stack.Peek() == '(')
                {
                    if (l[i] == ')') stack.Pop();
                    else stack.Push(l[i]);
                }
                else if (stack.Count != 0 && stack.Peek() == '{')
                {
                    if (l[i] == '}') stack.Pop();
                    else stack.Push(l[i]);
                }
                else
                {
                    stack.Push(l[i]);
                }
            }

            if (stack.Count == 0) return true;
            else return false;
        }
    }
}
