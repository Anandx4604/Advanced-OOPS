using System;
using System.Runtime.ConstrainedExecution;
namespace Assignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            RegisterPerson register1 = new RegisterPerson("Anand",Gender.Male,new DateTime(2000,11,05),9889839893,MaritalStatus.Single,"Aruldoss","Anusha","Chennai",1,new DateTime(2024,05,05));
            System.Console.WriteLine(register1.ShowInfo()); 

        }
    }
}