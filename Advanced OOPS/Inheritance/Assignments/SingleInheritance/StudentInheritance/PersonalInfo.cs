using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInheritance
{
    public enum Gender{Select,Male,Female,Transgender}
    public class PersonalInfo
    {

        // Program for getting and showing student details: Create 2 student details
        // Class PersonalInfo:
        // Properties: Name, FatherName, Phone ,Mail, DOB, Gender
        // Constructor to assign values

        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string MailID { get; set; }
        public DateTime DOB { get; set; }
        public Gender StudentGender { get; set; }

        public PersonalInfo(string name,string fatherName,long phone, string mailID,DateTime dob, Gender studentGender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            MailID = mailID;
            DOB = dob;
            StudentGender = studentGender;
        }

    }
}