using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInheritance
{
    public class StudentInfo : PersonalInfo
    {   
        // List<StudentInfo> studentList = new List<StudentInfo>();
        // Class StudentInfo: inherits PersonalInfo

        // Propeties: RegisterNumber, Standard, Branch, AcadamicYear

        // Method:  ShowStudentInfo
        private static int s_registrationNumber = 1000;
        public string  RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public string AcademicYear { get; set; }

        public StudentInfo(string name, string fatherName, long phone, string mailID,
        DateTime dob, Gender studentGender, string standard, string branch, string academicYear) : base(name, fatherName, phone, mailID, dob, studentGender)
        {
            // Name = name;
            // FatherName = fatherName;
            // Phone = phone;
            // MailID = mailID;
            // DOB = dob;
            // StudentGender = studentGender;
            s_registrationNumber++;
            RegisterNumber = "STU" + s_registrationNumber;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }

        public string ShowStudentInfo()
        {
            return ($"{RegisterNumber} | {Name} | {FatherName} | {Phone} | {MailID} | {Standard} | {Branch} | {AcademicYear}");
        }
    }
}