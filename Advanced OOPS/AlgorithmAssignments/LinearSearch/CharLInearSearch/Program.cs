using System;
namespace LinearSearchAlgorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] values = { 'g', 'h', 'i', 'j', 'a', 'b', 'c', 'd', 'e', 'f' };
            Array.Sort(values);
            int index = LinearSearch(values, 'd');
            System.Console.WriteLine("\nLinear Search Algorithm");
            if (index > -1)
            {
                System.Console.WriteLine($"Element d Found at index:{index}");
            }
            else
            {
                System.Console.WriteLine("Element not found!");
            }

        }

        public static int LinearSearch(char[] values, char searchElement)
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