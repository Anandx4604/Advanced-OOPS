using System;
namespace LinearSearchAlgorithm
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] values = {13,14,15,23,56,2,52,34};
            int index = LinearSearch(values,2);
            System.Console.WriteLine("Linear Search Alogorithm");
            System.Console.WriteLine($"Element Found at index:{index}");

        }

        public static int LinearSearch(int[] values, int searchElement)
        {
            int position = -1;
            for(int index = 0;index<values.Length-1;index++)
            {
                if(values[index] == searchElement)
                {
                    position=index;
                    break;
                }
            }
            return position;
        }
    }
}