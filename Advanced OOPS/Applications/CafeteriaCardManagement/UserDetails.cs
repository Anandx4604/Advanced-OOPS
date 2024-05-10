using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class UserDetails : PersonalDetails
    {
        //field
        private double _balance;
        private static int s_userID = 1000;
        public string UserID { get; }
        public string WorkstationNumber { get; set; }
        public double WalletBalance { get { return _balance; } }

        public UserDetails(string name, string fatherName, long mobile, string mailID, Gender personGender, string workstationNumber, double walletBalance) : base(name, fatherName, mobile, mailID, personGender)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            WorkstationNumber = workstationNumber;
            _balance = walletBalance;
        }

        public void WalletRecharge(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public bool DeductAmount(double amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }
    }


}