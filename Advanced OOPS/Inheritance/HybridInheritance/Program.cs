using System;
using System.Collections.Generic;
namespace HybridInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Operations.AadharRegistration();

            List<AadharDetails> aadharList = new List<AadharDetails>();
            AadharDetails newAadhar = new AadharDetails("BID1001","Anand","Aruldoss",Gender.Male,new DateTime(2000,11,05),"No.59,Rajiv Gandhi nagar, chennai-600116");
            aadharList.Add(newAadhar);
            System.Console.WriteLine($"You have Registered Successfully! Your Aadhar ID:{newAadhar.AadharID}");
            foreach(AadharDetails aadhar in aadharList)
            {
                System.Console.WriteLine($"{aadhar.BirthID} | {aadhar.Name} | {aadhar.FatherName} | {aadhar.Gender} | {aadhar.DOB:dd/MM/yyyy} | {aadhar.Address} |");
            }


        }
    }
}