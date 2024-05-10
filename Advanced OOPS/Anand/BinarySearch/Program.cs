using System;
using System.Security.Cryptography.X509Certificates;
namespace BinarySearch;
class program
{
    public static void Main(string[] args)
    {
        string[] values = {"SF1005","SF1002","SF1003","SF1001","SF1004","SF1006","SF1007","SF1008","SF1009","SF1010"};
        System.Console.WriteLine("given Array:");
        foreach(string value in values)
        {
            System.Console.Write($"{value} ");
        }

        System.Console.WriteLine("\nSorted Array:");
        Array.Sort(values);
        foreach(string value in values)
        {
            System.Console.Write($"{value} ");
        }

        System.Console.WriteLine("\nBinary Search");
        int position = BinarySearch(values,"SF1005");
        if(position>-1)
        {
            System.Console.WriteLine($"Element SF1005 Found at index:{position}");
        }
        else
        {
            System.Console.WriteLine("Element not found!");
        }

        int BinarySearch(string[] values, string searchElement)
        {
            int left = 0;
            int right = values.Length-1;
            int middle = (right+left)/2;
            while(left<=right)
            {
                if(values[middle] == searchElement)
                {
                    return middle;
                }

                else if(values[left].CompareTo(searchElement)>0)
                {
                    left = middle+1;
                }

                else
                {
                    right = middle-1;
                }
            }
            return -1;
          
            
        }

    }
}