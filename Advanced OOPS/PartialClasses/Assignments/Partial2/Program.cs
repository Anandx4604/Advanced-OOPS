using System;
namespace Partial2
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentInfo student = new StudentInfo("STU1005","Anand","Male",new DateTime(2000,11,05),98767676788,98,99,97);
            System.Console.WriteLine("Student Details:");
            System.Console.WriteLine(student.Display());
        }
    }
}