using System;
using System.Collections.Generic;
namespace StudentInheritance;
class Program
{
    public static void Main(string[] args)
    {
        // List<StudentInfo> studentList = new List<StudentInfo>();
        StudentInfo student1 = new StudentInfo("Anand", "Aruldoss", 745671883, "anand@gmail.com", new DateTime(2000, 11, 05), Gender.Male, "Eleventh", "ComputerScience", "2018-2019");
        string result1 = student1.ShowStudentInfo();
        System.Console.WriteLine(result1);
        // studentList.Add(student1);
        // student1.ShowStudentInfo();
        StudentInfo student2 = new StudentInfo("Ajith", "Kumar", 945671883, "ajith@gmail.com", new DateTime(1999, 05, 17), Gender.Male, "Tweleth", "Biology", "2017-2018");
        // studentList.Add(student2);
        string result2 = student2.ShowStudentInfo();
        System.Console.WriteLine(result2);
    }
}