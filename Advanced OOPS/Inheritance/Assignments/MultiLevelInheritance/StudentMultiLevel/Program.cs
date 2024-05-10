using System;
using System.Collections.Generic;
namespace StudentMultiLevel;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student1 = new StudentInfo("Anand", "Aruldoss", 745671883, "anand@gmail.com", new DateTime(2000, 11, 05), Gender.Male, "Eleventh", "ComputerScience", "2018-2019");
        System.Console.WriteLine(student1.ShowStudentInfo());
        HSCDetails Details1 = new HSCDetails("Anand", "Aruldoss", 745671883, "anand@gmail.com", new DateTime(2000, 11, 05), Gender.Male, "Eleventh", "ComputerScience", "2018-2019", 160, 170, 180);
        System.Console.WriteLine("Student1 Marks");
        System.Console.WriteLine(Details1.GetMarks());
        Details1.Calculate();
        System.Console.WriteLine("Student1 Marksheet");
        System.Console.WriteLine(Details1.ShowMarksheet());

        StudentInfo student2 = new StudentInfo("Ajith", "Kumar", 945671883, "ajith@gmail.com", new DateTime(1999, 05, 17), Gender.Male, "Tweleth", "Biology", "2017-2018");
        System.Console.WriteLine(student2.ShowStudentInfo());
        HSCDetails Details2 = new HSCDetails("Ajith", "Kumar", 945671883, "ajith@gmail.com", new DateTime(1999, 05, 17), Gender.Male, "Tweleth", "Biology", "2017-2018", 160, 170, 190);
        System.Console.WriteLine("Student2 Marks");
        System.Console.WriteLine(Details2.GetMarks());
        Details2.Calculate();
        System.Console.WriteLine("Student2 Marksheet");
        System.Console.WriteLine(Details2.ShowMarksheet());
    }
}