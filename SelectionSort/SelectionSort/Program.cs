using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = new int[7] { 20, 24, 2, 10, 4, 11, 5 };
            int temp;
            int low;

            for (int i = 0; i < array.Length - 1; i++)
            {
                low = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[low])
                    {
                        low = j;
                    }
                }
                temp = array[low];
                array[low] = array[i];
                array[i] = temp;

            }

            Console.WriteLine("The following is a Selection Sort Method");
            Console.WriteLine("Unsorted Array: {20, 24, 2, 10, 4, 11, 5}");
            Console.WriteLine();
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < array.Length; i++)
            {                
                Console.Write("{0},", array[i]);
            }
            Console.ReadLine();

        }
    }
}
