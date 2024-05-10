using System;
using System.Runtime.InteropServices;
namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            SavingsAccount account1 = new SavingsAccount("Anand", "Male", new DateTime(2000, 11, 05), 89898989898, "XIB333", 3646364365635, "DGP7672762", 1093838383, AccountType.Savings, 500, "Indian Bank", "IDFI8878", "Besant Nagar");
            if (account1.Deposit(1000))
            {
                System.Console.WriteLine("Amount deposited Successfully!");
            }
            else
            {
                System.Console.WriteLine("Enter valid amount!");
            }


            if (account1.Withdraw(1000))
            {
                System.Console.WriteLine("Amount Withdrawn Successfully!");
            }
            else
            {
                System.Console.WriteLine("Enter valid amount!");
            }

            System.Console.WriteLine("Balance:");
            System.Console.Write(account1.BalanceCheck());


        }
    }
}
