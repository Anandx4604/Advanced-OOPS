using System;
namespace StringLinearSearch
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] values = { "SF1002", "SF1004", "SF1003", "SF1001", "SF1005", "SF1006", "SF1007", "SF1008", "SF1009", "SF1010", "SF1011", "SF1012", "SF1013", "SF1014", "SF1015", "SF1016", "SF1017", "SF1018", "SF1019", "SF1020" };
            System.Console.WriteLine("Given array:");
            foreach (string value in values)
            {
                System.Console.Write($"{value} ");
            }

            System.Console.WriteLine($"\nSorted Array:");
            Array.Sort(values);
            foreach (string value in values)
            {
                System.Console.Write($"{value} ");
            }

            int index = LinearSearch(values, "SF1001");
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

        public static int LinearSearch(string[] values, string searchElement)
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