using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public enum Gender { Select, Male, Female, Transgender }
    public class PersonalDetails
    {
        //properties
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public string MailID { get; set; }
        public Gender PersonGender { get; set; }
        public PersonalDetails(string name, string fatherName, long mobile, string mailID, Gender personGender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            MailID = mailID;
            PersonGender = personGender;
        }
        interface IBalance
        {
            void WalletRecharge();
            void DeductAmount();
        }
    }
}