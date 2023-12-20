using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CheckingAccount : Account
    {
        private const double WithdrawalFee = 1.50;

        public CheckingAccount(string name = "Unnamed Checking Account", double balance = 0.0)
            : base(name, balance)
        {
        }

        public new bool Withdraw(double amount)
        {
            bool success = base.Withdraw(amount);
            if (success)
                base.Withdraw(WithdrawalFee); 
            return success;
        }

        
    }

}
