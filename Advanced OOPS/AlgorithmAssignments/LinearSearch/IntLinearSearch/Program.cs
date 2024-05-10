using System;
namespace LinearSearchAlgorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] values = { 9, 7, 8, 1, 2, 3, 4, 5, 6, 10 };
            System.Console.WriteLine("Given Array:");
            foreach (int value in values)
            {
                System.Console.Write($"{value} ");
            }

            System.Console.WriteLine($"\nSorted Array:");
            Array.Sort(values);
            foreach (int value in values)
            {
                System.Console.Write($"{value} ");
            }

            int index = LinearSearch(values, 5);
            System.Console.WriteLine("\nLinear Search Alogorithm");
            if (index > -1)
            {
                System.Console.WriteLine($"Element 2 Found at index:{index}");
            }
            else
            {
                System.Console.WriteLine("Element not found!");
            }

        }

        public static int LinearSearch(int[] values, int searchElement)
        {
            int position = -1;
            for (int index = 0; index < values.Length - 1; index++)
            {
                if (values[index] == searchElement)
                {
                    position = index;
                    break;
                }
            }
            return position;
        }
    }
}