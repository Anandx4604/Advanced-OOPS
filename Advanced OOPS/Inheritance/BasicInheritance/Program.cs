using System;
namespace BasicInheritance;
class Program
{
   public static void Main(string[] args)
   {
    //    College college = new College();
    //    college.CollegeMethod();
       Department department = new Department();
       department.DepartmentMethod();
       department.CollegeMethod(); // we can access base class methods with object we created for derived class

       Lab lab = new Lab();
       lab.LabMethod();
       lab.CollegeMethod();

   } 
}
