using System;
namespace IntBinarySearchAlgorithm;
class Program
{
    public static void Main(string[] args)
    {
        int[] values = { 9, 7, 8, 1, 2, 3, 4, 5, 6, 10 };
        System.Console.WriteLine("Given Array:");
        foreach(int value in values )
        {
            System.Console.Write($"{value} ");
        }
        System.Console.WriteLine($"\nSorted Array:");
        Array.Sort(values);
        foreach(int value in values )
        {
            System.Console.Write($"{value} ");
        }

        int elementFound = BinarySearch(values, 5);
        if (elementFound > -1)
        {
            System.Console.WriteLine($"\nElement 5 Found at index: {elementFound}");
        }
        else
        {
            System.Console.WriteLine("\nElement not Found!");
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