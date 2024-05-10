using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        public StudentInfo(string studentID, string name,string gender,DateTime dob,long mobile,double physics,double chemistry,double maths)
        {
            StudentID = studentID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }
    }
}