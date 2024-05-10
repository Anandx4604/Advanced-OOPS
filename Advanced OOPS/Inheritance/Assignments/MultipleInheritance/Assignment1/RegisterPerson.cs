using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class RegisterPerson : PersonalInfo, IShowData, IFamilyInfo
    {
        private static int s_registrationNumber = 1000;
        public string RegistrationNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }

        public RegisterPerson(string name,Gender personGender,DateTime dob,long mobile,MaritalStatus maritalStatus, string fatherName, string motherName, string houseAddress, int noOfSiblings, DateTime dateOfRegistration):base(name,personGender,dob,mobile, maritalStatus)
        {
            s_registrationNumber++;
            RegistrationNumber = "RID" + s_registrationNumber;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NoOfSiblings = noOfSiblings;
            DateOfRegistration = dateOfRegistration;
        }

        public new string ShowInfo()
        {
            return $"| {RegistrationNumber} | {Name} |{FatherName} | {MotherName} | {HouseAddress} | {NoOfSiblings} | {PersonGender} | {DOB:dd/MM/yyyy} | {Mobile} | {MaritalStatus} | {DateOfRegistration:dd/MM/yyyy}";
        }
    }
}