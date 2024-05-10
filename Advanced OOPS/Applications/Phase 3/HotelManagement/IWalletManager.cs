using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement
{
    public interface IWalletManager
    {
        public double WalletBalance { get;}
        public void WalletRecharge(double amount);
        public void DeductBalance(double amount);
    }
}