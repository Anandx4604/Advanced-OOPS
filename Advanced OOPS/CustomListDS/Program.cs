using System;
namespace CustomListDS
{
    class Program
    {
        public static void Main(string[] args)
        {
            //creating and declaring of List Datatype
            CustomList<int> numberList = new CustomList<int>();
            numberList.Add(10);
            numberList.Add(20);
            numberList.Add(30);
            numberList.Add(40);
            numberList.Add(50);
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(60);
            numbers.Add(70);
            numberList.AddRange(numbers);

            System.Console.WriteLine("List Values using For Loop:");
            for (int i = 0; i < numberList.Count; i++) //Count is used to track the list count
            {
                //using indexer we are printing here
                System.Console.WriteLine(numberList[i]);
            }
            System.Console.WriteLine("List Values using ForEach Loop:");
            foreach (int element in numberList)
            {
                System.Console.WriteLine(element);
            }

            bool result = numberList.Contains(40); // search an element in an array
            if (result)
            {
                System.Console.WriteLine("List Contains 40");

            }
            int position = numberList.IndexOf(20); //get index of an element
            System.Console.WriteLine($"Index position of 20 :{position}");

            numberList.Insert(2, 30); //Insert at specific position 
            System.Console.WriteLine("Inserting 30 at index of 2 in list:");
            foreach (int element in numberList)
            {
                System.Console.WriteLine(element);
            }
            
            System.Console.WriteLine("Removing element in index 2");
            numberList.RemoveAt(2);
           foreach (int element in numberList)
            {
                System.Console.WriteLine(element);
            }

            bool temp = numberList.Remove(30);
            System.Console.WriteLine("Removing 30 in List:");
            foreach (int element in numberList)
            {
                System.Console.WriteLine(element);
            }

            numberList.InsertRange(3, numbers);
            System.Console.WriteLine("Insert Range:");
            foreach (int element in numberList)
            {
                System.Console.WriteLine(element);
            }

            System.Console.WriteLine("Reversed List:");
            numberList.Reverse();
            foreach (int element in numberList)
            {
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine("Sorting the list in Ascending Order:");
            numberList.Sort();
            foreach (int element in numberList)
            {
                System.Console.WriteLine(element);
            }

           
        }
    }
}