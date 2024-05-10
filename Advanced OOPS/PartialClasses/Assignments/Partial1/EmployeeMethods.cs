using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial1
{
    public partial class EmployeeInfo
    {
        public void Update(string employeeID, string name, string gender, DateTime dob, long mobile)
        {
            EmployeeID = employeeID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }

        public string Display()
        {
            return $"| {EmployeeID} | {Name} | {Gender} | {DOB:dd/MM/yyyy} | {Mobile}";
        }
    }
}