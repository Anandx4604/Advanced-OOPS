using System;
using System.Collections.Generic;
namespace QueueDS;
class Program
{
    public static void Main(string[] args)
    {
        CustomQueue<int> myQueue = new CustomQueue<int>();
        myQueue.Enqueue(10);
        myQueue.Enqueue(20);
        myQueue.Enqueue(30);
        myQueue.Enqueue(40);
        myQueue.Enqueue(50);
        System.Console.WriteLine("For Each:");
        foreach (int value in myQueue)
        {
            System.Console.WriteLine($"value:{value}");
        }
        System.Console.WriteLine("Peek");
        System.Console.WriteLine(myQueue.Peek());
        System.Console.WriteLine("Dequeue");
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine("After all Deletion:");
        foreach (int value in myQueue)
        {
            System.Console.WriteLine($"value:{value}");
        }




    }

}
