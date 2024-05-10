using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class TCS : Salary
    {
        public override string CompanyName { get ; set ; }
        public TCS(string employeeID, string employeeName, string companyName)
        {
            EmployeeID = employeeID;
            EmployeeName = EmployeeName;
            CompanyName = companyName;
        }

        public override void CalculateSalary(int days, double salaryPerDay)
        {
            double salary = days*salaryPerDay;
            TotalSalary = 0.80 * salary + salary;
        }
    }
}