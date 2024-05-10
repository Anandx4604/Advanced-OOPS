using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }

        public PersonalDetails(string name, string fatherName, Gender gender,DateTime dob)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
        }
    }
}