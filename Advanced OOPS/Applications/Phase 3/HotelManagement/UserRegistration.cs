using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class UserRegistration : PersonalDetails, IWalletManager
    {
        private double _balance;
        private static int s_userID = 1000;
        public string UserID { get; set; }
        public double WalletBalance { get { return _balance; } }
        public UserRegistration(string userName, long mobileNumber, long aadharNumber, string address, FoodType foodType, Gender personGender, double walletBalance) : base(userName, mobileNumber, aadharNumber, address, foodType, personGender)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            _balance = walletBalance;
        }

        public void WalletRecharge(double amount)
        {
            if(amount>0)
            {
                _balance+=amount;
            }
        }

        public void DeductBalance(double amount)
        {
            if(amount<=WalletBalance)
            {
                _balance-=amount;
            }
        }
    }
}