using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial
{
    public partial class StudentDetails
    {
        private static int s_studentID = 1000;
        private double _balance;
        
        public partial void GetBalance(double amount);
    }
}