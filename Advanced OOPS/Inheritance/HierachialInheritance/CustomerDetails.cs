using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierachialInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_cutomerID = 1000;
        public string CustomerID { get;}
        public double Balance{get;set;}

        public CustomerDetails(string name, string fatherName, Gender gender,DateTime dob,double balance):base(name,fatherName,gender,dob)
        {
            s_cutomerID++;
            CustomerID = "CID" + s_cutomerID;
            Balance = balance;

        }
    }
}