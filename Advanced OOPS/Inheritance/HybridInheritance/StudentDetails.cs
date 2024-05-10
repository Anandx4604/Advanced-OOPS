using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HybridInheritance;

namespace HybridInheritance
{
    public class StudentDetails : AadharDetails
    {
        private static int s_studentID = 1000;
        public string StudentID { get; }
        public string Standard {get;set;}

        public StudentDetails(string birthID, string aadharID,string name, string fatherName,
        Gender gender,DateTime dob,string address, string standard):base(aadharID,birthID,name,fatherName,gender,dob,address)
        {
            s_studentID++;
            StudentID = "STU" + s_studentID;
            Standard = standard;
        }

    }
}