﻿using System;
using System.Collections.Generic;
namespace CustomStack;
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(11);
            myStack.Push(12);
            myStack.Push(13);
            myStack.Push(14);
            myStack.Push(15);
            System.Console.WriteLine("Peeking at Top of Stack:");
            System.Console.WriteLine(myStack.Peek());
            System.Console.WriteLine("Popping Top value in Stack:");
            System.Console.WriteLine(myStack.Pop());
            System.Console.WriteLine("Popping Top value in Stack:");
            System.Console.WriteLine(myStack.Pop());
            System.Console.WriteLine("Popping Top value in Stack:");
            System.Console.WriteLine(myStack.Pop());
            System.Console.WriteLine("Popping Top value in Stack:");
            System.Console.WriteLine(myStack.Pop());
            System.Console.WriteLine("Popping Top value in Stack:");
            System.Console.WriteLine(myStack.Pop());
            // System.Console.WriteLine("Popping Top value in Stack:");
            // System.Console.WriteLine(myStack.Pop());


        }
    }
    