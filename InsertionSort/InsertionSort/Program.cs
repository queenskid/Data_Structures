using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = new int[10] { 20, 2, 1, 33, 8, 18, 22, 15, 25, 4 };
            Console.WriteLine("\nUnsorted Array:");
            Print(numbers);
            Console.WriteLine("\nSorted Array :");
            Print(InsertionSort(numbers));
            Console.WriteLine("\n");
            Console.ReadLine();
        }

        static int[] InsertionSort(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (Array[j - 1] > Array[j])
                    {
                        int temp = Array[j - 1];
                        Array[j - 1] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            return Array;
        }

        public static void Print(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}
