using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial
{
    public partial class StudentMethods
    {
        public partial void GetBalance(double amount)
        {
            _balance = amount;
        }

        public partial double ShowBalance()
        {
            return _balance;
        }
    }
}