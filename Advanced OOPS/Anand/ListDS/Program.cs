using System;
using System.Collections;
using System.Collections.Generic;
namespace ListDS;
class Program
{
    public static void Main(string[] args)
    {
        CustomList<int> userList = new CustomList<int>();
        userList.Add(10);
        userList.Add(20);
        userList.Add(30);
        System.Console.WriteLine("Custom For Each:");
        foreach (int element in userList)
        {
            System.Console.WriteLine(element);
        }
        // userList.Add(40);
        CustomList<int> numbers = new CustomList<int>();
        numbers.Add(40);
        numbers.Add(50);
        userList.AddRange(numbers);
        System.Console.WriteLine("Adding 40 and 50 from another list:");
        foreach (int element in userList)
        {
            System.Console.WriteLine(element);
        }

        userList.Remove(30);
        System.Console.WriteLine("Removing 30 from the list:");
        foreach (int element in userList)
        {
            System.Console.WriteLine(element);
        }

        userList.RemoveAt(2); // justt position to delete
        System.Console.WriteLine("Removing 2 index element from the list:");
        foreach (int element in userList)
        {
            System.Console.WriteLine(element);
        }



    }
}
