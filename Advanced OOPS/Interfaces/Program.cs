using System;
using System.Collections.Generic;
using Interfaces;
namespace Interface;
class Program
{
    public static void Main(string[] args)
    {
        // IMarkDetails marks = new IMarkDetails(); cant create object for interfaces
        StudentDetails student = new StudentDetails(50,50,50);
        // we perform dynamic binding
        IMarkDetails mark = new StudentDetails(70,80,90);
        System.Console.WriteLine($"{mark.Mark1} | {mark.Mark2} {mark.Mark3}");

        Marksheet mark1 = new Marksheet(30,40,50);
        System.Console.WriteLine($"{mark1.Mark1} {mark1.Mark2} | {mark.Mark3} |");

        List<IMarkDetails> markDetailsList = new List<IMarkDetails>();
        markDetailsList.Add(student);
        markDetailsList.Add(mark);
        markDetailsList.Add(mark1);

        // foreach (var item in collection)
        // {
            
        // }

    }
}