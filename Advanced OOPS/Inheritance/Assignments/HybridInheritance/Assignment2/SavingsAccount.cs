using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public enum AccountType { Select, Savings, Balance };
    public class SavingsAccount : IDInfo, ICalculate, IBankInfo
    {
        private static double _balance;
        public long AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public double WalletBalance { get { return _balance; } }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }

        public SavingsAccount(string name, string gender, DateTime dob, long phone, string voterID, long aadharID, string panNumber, long accountNumber, AccountType accountType,double walletBalance, string bankName,string ifsc,string branch): base(name, gender, dob, phone, voterID, aadharID, panNumber)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            _balance = walletBalance;
            BankName = bankName;
            IFSC = ifsc;
            Branch = branch;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= WalletBalance)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }

        public double BalanceCheck()
        {
            return _balance;
        }
    }
}