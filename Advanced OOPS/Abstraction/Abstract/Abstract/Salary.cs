using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    //partial absstraction
    public abstract class Salary
    {
        //it cant be a static class
        //field possible
        //no constructor
        //normal and abstract method available
        // objects cant be created
        //can be only used iwth inheritance

        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public abstract string CompanyName{get;set;}
        public double TotalSalary  { get; set; }

        public abstract void CalculateSalary (int days, double salaryPerDay);


    }
}