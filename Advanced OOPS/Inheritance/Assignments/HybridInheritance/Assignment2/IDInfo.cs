using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class IDInfo : PersonalInfo
    {
        public string VoterID { get; set; }
        public long AadharID { get; set; }
        public string PanNumber { get; set; }
        public IDInfo(string name, string gender, DateTime dob, long phone,string voterID,long aadharID,string panNumber) : base(name, gender, dob, phone)
        {
            VoterID = voterID;
            AadharID = aadharID;
            PanNumber = panNumber;
        }
    }
}