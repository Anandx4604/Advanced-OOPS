using System;
namespace Partial1
{
    class Program
    {
        public static void Main(string[] args)
        {
         EmployeeInfo employee1 = new EmployeeInfo("SF4603","Anand","Male",new DateTime(2000,11,05),988989898989);
         System.Console.WriteLine(employee1.Display());
         System.Console.WriteLine("Updating Employee Details");
         employee1.Update("SF4604","Anand Aruldoss","Male",new DateTime(2000,11,05),9853546321);
         System.Console.WriteLine(employee1.Display());   
        }
    }
}