using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public enum Gender{Select,Male,Female,Transgender}
    public class BirthDetails
    {
        //field
        private static int s_birthID = 1000;
        // Birth registeration : Birth id, name father name , gender , date of birth
        public string BirthID { get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }

        public BirthDetails(string name,string fatherName,Gender gender, DateTime dob)
        {
            s_birthID++;
            BirthID = "BID" + s_birthID;
            Name = name;
            FatherName = fatherName;
            Gender= gender;
            DOB = dob;
        }

         public BirthDetails(string birthID, string name,string fatherName,Gender gender, DateTime dob)
        {
            BirthID = birthID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
        }
    }
}