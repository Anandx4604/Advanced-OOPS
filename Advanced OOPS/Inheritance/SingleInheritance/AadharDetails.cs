using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class AadharDetails : BirthDetails //implementing birth details
    {
        public static int s_aadharID = 1000;
        public string AadharID { get;}
        public string Address { get; set; }

        //constructor for base class
        public AadharDetails(string birthID,string name,string fatherName,Gender gender, DateTime dob,string address):base(name,fatherName,gender,dob)
        {
            
            s_aadharID++;
            AadharID = "AID" + s_aadharID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
            Address = address;
        }
    }
}