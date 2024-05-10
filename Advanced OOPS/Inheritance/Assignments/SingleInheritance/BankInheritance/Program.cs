using System;
namespace BankInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            AccountInfo account1 = new AccountInfo("Anand","Aruldoss",747757755,"anand@gmail.com","Male",100022221,"Besant Nagar","IDIB899",500);
            System.Console.WriteLine("Account Info:");
            System.Console.WriteLine(account1.ShowAccountInfo());
            System.Console.Write("Enter amount to Deposit:");
            double amount = double.Parse(Console.ReadLine());
            account1.Deposit(amount);
            System.Console.WriteLine($"Amount {amount} Deposited Successfully!");
            System.Console.Write("Enter amount to withdraw:");
            double withdrawAmount = double.Parse(Console.ReadLine());
            account1.Withdraw(withdrawAmount);
            System.Console.WriteLine($"Amount: {withdrawAmount} successffully!");
            double currentBalance = account1.ShowBalance();
            System.Console.WriteLine($"Current balance:{currentBalance}");
            

        }
    }
}