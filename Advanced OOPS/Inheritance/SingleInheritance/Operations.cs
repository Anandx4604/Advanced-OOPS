using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public static class Operations
    {
        // static List<BirthDetails> birthList = new List<BirthDetails>();
        static List<AadharDetails> aadharList = new List<AadharDetails>();
        public static AadharDetails currentLoginUser;
        public static void AadharRegistration()
        {
            System.Console.Write("Enter your Birth ID:");
            string birthID = Console.ReadLine().ToUpper();
            System.Console.Write("Enter your Name:");
            string name = Console.ReadLine();
            System.Console.Write("Enter your Father Name:");
            string fatherName = Console.ReadLine();
            System.Console.Write("Enter your Gender:");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.Write("Enter your Date of Birth:(dd/MM/yyyy):");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.WriteLine("Enter your Address:");
            string address = Console.ReadLine();
            AadharDetails newAadhar = new AadharDetails(birthID,name, fatherName, gender, dob, address);
            aadharList.Add(newAadhar);
            System.Console.WriteLine($"You have Registered Successfully! Your Aadhar ID:{newAadhar.AadharID}");
            foreach(AadharDetails aadhar in aadharList)
            {
                System.Console.WriteLine($"{aadhar.BirthID} | {aadhar.Name} | {aadhar.FatherName} | {aadhar.Gender} | {aadhar.DOB:dd/MM/yyyy} | {aadhar.Address} |");
            }

        }
        // public static void AadharRegistration()
        // {
        //     System.Console.WriteLine("Enter your birth ID:");
        //     string birthID = Console.ReadLine();
        //     foreach (BirthDetails birth in birthList)
        //     {
        //         if(birthID == birth.BirthID)
        //         {
        //             System.Console.WriteLine("Enter your Address:");
        //         }
        //     }
        // }
    }
}