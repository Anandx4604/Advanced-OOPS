using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class PersonalInfo
    {
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo(string registrationNumber,string name,string fatherName,long phone,DateTime dob,string gender)
        {
            RegistrationNumber = registrationNumber;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
        }
    }
}