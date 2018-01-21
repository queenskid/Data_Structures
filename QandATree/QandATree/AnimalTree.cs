using System;
using System.Collections.Generic;
using System.Text;

namespace QandATree
{
    class AnimalTree
    {
        public static Node Root = null;

        public static void GameLogic(Node root)
        {
            Console.WriteLine(root.Value);
            string input = Console.ReadLine();
            if (input == "y" || input == "yes" || input == "YES" || input == "Y")
            {
                Console.WriteLine(root.Left.Value);
                input = Console.ReadLine();
                if (input == "y" || input == "yes" || input == "YES" || input == "Y")
                {
                    GameLogic(Root);
                }
                else
                {
                    if (root.Left.Right == null)
                    {
                        QandATree(root.Left);
                    }
                    else
                    {
                        GameLogic(root.Left.Right);
                    }
                }
            }
            else if (input == "n" || input == "no" || input == "NO" || input == "N")
            {
                if (root.Right == null)
                {
                    QandATree(root);
                }
                else
                {
                    GameLogic(root.Right);
                }
            }
        }

        public static void QandATree(Node node)
        {
            Console.WriteLine("What Question could I have asked to guess your animal? Please enter below");
            string q = Console.ReadLine();

            Console.WriteLine("Enter the animal name you had in mind");
            string a = Console.ReadLine();

            Node question = new Node() { Value = q };
            Node animal = new Node() { Value = a };

            node.Right = question;
            node.Right.Left = animal;
        }
    }
}
