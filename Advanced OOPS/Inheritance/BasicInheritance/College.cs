using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class College
    {
        public string college = "SyncFusion University"; //private field
        public string prinicipalName = "Baskaran"; //by default class fields are private

        public void CollegeMethod()
        {
            System.Console.WriteLine($"\nIn college class, College name is {college}");
        }
    }

    public class Department : College
    {
        public string departmentName = "MCA";
        public void DepartmentMethod()
        {

            System.Console.WriteLine($"\nIn Department class, Department Name is {departmentName}");
            System.Console.WriteLine($"\nIn Department class, College Prinicipal Name is {prinicipalName}");
        }
    }

    public class Lab : College
    {
        public void LabMethod()
        {
            string labName = "Computer Lab";
            System.Console.WriteLine($"In Lab class, Lab Name is {labName}");
            // System.Console.WriteLine($"In Lab class, Lab is allocated for {departmentName}");
            System.Console.WriteLine($"In Lab class, we Have lab facilities in our college {college}");
        }
    }
}