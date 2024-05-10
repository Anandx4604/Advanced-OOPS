using System;
namespace BinarySearchAlgorithm;
class Program
{
    public static void Main(string[] args)
    {
        int[] values = { 10, 11, 12, 13, 14, 15 };
        // System.Console.WriteLine($"Sorted Array:{}");
        int elementFound = BinarySearch(values, 13);
        if (elementFound > -1)
        {
            System.Console.WriteLine($"Element Found at index: {elementFound}");
        }
        else
        {
            System.Console.WriteLine("Element not Found!");
        }
    }
    static int BinarySearch(int[] values, int searchElement)
    {

        int left = 0;
        int right = values.Length - 1;
        while (left <= right)
        {
            int middle = (right + left) / 2;
            if (values[middle] == searchElement)
            {
                return middle;
            }

            //if search element is greater than middle 
            else if (values[middle] < searchElement)
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