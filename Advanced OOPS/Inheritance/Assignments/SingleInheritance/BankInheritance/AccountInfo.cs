using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankInheritance
{
    public class AccountInfo : PersonalInfo
    {
        public long AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }
        public AccountInfo(string name, string fatherName, long phone, string mail, string gender, long accountNumber, string branchName, string ifscCode, double balance) : base(name, fatherName, phone, mail, gender)
        {
            AccountNumber = accountNumber;
            BranchName = branchName;
            IFSCCode = ifscCode;
            Balance = balance;
        }

        public string ShowAccountInfo()
        {
            return $"| {Name} | {FatherName} | {Phone} | {Mail} | {AccountNumber} | {IFSCCode} | {BranchName}";
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
        }

        public double ShowBalance()
        {
            return Balance;
        }
    }
}

