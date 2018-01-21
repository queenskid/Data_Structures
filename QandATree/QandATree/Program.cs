using System;

namespace QandATree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Visitor, Lets play a little guessing game. You will be both the guesser and question maker");

            Node root = new Node();
            root.Value = "Is it amphibious?";
            root.Left = new Node() { Value = "Is it a fish?" };

            AnimalTree.Root = root;
            while (true)
            {
                AnimalTree.GameLogic(AnimalTree.Root);
            }
        }
    }
}