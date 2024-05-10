using System;
using System.Collections.Generic;
namespace BinarySearchAlgorithm;
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
        int position = BinarySearch(values, "SF1001");
        System.Console.WriteLine("\nBinary Search");
        if (position > -1)
        {
            System.Console.WriteLine($"Element Found at index: {position}");
        }
        else
        {
            System.Console.WriteLine("Element not Found!");
        }
    }
    static int BinarySearch(string[] values, string searchElement)
    {

        int left = 0;
        int right = values.Length - 1;
        while (left <= right)
        {
            int middle = (right + left) / 2;

            int result = values[middle].CompareTo(searchElement);

            if (result == 0)
            {
                return middle;
            }

            //if search element is greater than middle 
            else if (result < 0)
            {
                //search in the right half by changing value of Left
                left = middle + 1;
            }

            else
            {
                //If search element is less than middle
                //search in the left half by changing value of Right
                right = middle - 1;
            }
        }
        // element not present in array
        return -1;
    }

}