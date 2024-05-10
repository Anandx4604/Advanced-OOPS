using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public interface ICalculate
    {
        bool Deposit(double amount);
        bool Withdraw(double amount);
        double BalanceCheck();
    }
}