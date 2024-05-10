using System;
using System.Collections.Generic;
namespace Abstract
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Salary salary = new Salary();
            Syncfusion syncfusion = new Syncfusion("SF4604","Anand","Syncfusion");
            TCS tcs = new TCS("TF1005","Ajith","TCS");
            List<Salary> salariesList = new List<Salary>();
            salariesList.Add(syncfusion);
            salariesList.Add(tcs);

            foreach (Syncfusion sf in salariesList)
            {
                System.Console.WriteLine($"{sf.EmployeeID} | {sf.EmployeeName} | {sf.CompanyName}");
            }
        }
    }
}