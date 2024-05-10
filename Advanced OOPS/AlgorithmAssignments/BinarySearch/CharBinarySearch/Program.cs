using System;
namespace BinarySearchAlgorithm;
class Program
{
    public static void Main(string[] args)
    {
        char[] values = { 'g', 'h', 'i', 'j', 'a', 'b', 'c', 'd', 'e', 'f' };
        Array.Sort(values);
        int position = BinarySearch(values, 'd');
        System.Console.WriteLine("\nBinary Search");
        if (position > -1)
        {
            System.Console.WriteLine($"Element d Found at index: {position}");
        }
        else
        {
            System.Console.WriteLine("Element not Found!");
        }
    }
    static int BinarySearch(char[] values, char searchElement)
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