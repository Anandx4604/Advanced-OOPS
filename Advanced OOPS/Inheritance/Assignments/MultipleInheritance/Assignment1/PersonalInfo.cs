using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public enum Gender{Select,Male,Female,Transgender};
    public enum MaritalStatus{Select,Single,Married};
    public class PersonalInfo : IShowData
    {
        public string Name { get; set; }
        public Gender PersonGender { get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        public PersonalInfo(string name,Gender personGender,DateTime dob,long mobile,MaritalStatus maritalStatus)
        {
            Name = name;
            PersonGender = personGender;
            DOB = dob;
            Mobile = mobile;
            MaritalStatus = maritalStatus;
        }
        public string ShowInfo()
        {
            return $"| {Name} |{PersonGender} | {DOB:dd/MM/yyyy} | {Mobile} | {MaritalStatus} |";
        }
    }
}