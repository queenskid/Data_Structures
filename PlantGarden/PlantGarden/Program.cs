using System;


namespace PlantGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            Char P = 'X';
            for (int i = 0; i < 5; i++)
            {
                for (int n = 0; n < 5; n++)
                {
                    Console.Write(P);
                }

                Console.WriteLine();
                P = (P == 'X') ? 'Y' : 'X';
            }

            Console.WriteLine();

            P = 'X';
            for (int i = 0; i < 5; i++)
            {
                for (int n = 0; n < 5; n++)
                {
                    Console.Write(P);
                    P = (P == 'X') ? 'Y' : 'X';
                }
                Console.WriteLine();

            }

            Console.ReadLine();


        }
    }
}