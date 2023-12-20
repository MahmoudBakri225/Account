using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TrustAccount : Account
    {
        private double interestRate;
        private double withdrawalsThisYear;

        public TrustAccount(string name = "Unnamed Trust Account", double balance = 0.0, double interestRate = 1.0 )
            : base(name, balance)
        {
            this.interestRate = interestRate;
            
        }

        //public new bool Deposit(double amount)
        //{
        //    bool success = base.Deposit(amount);
        //    if (success && amount >= 5000)
        //        base.Deposit(50);
        //    amount = amount * (100 * interestRate);
        //    return base.Deposit(amount);

        //    return success;

        //}
        public new bool Deposit(double amount)
        {
            bool success = base.Deposit(amount);

            if (success && amount >= 5000)
            {
                base.Deposit(50);
            }

            double interest = amount * interestRate / 100;
            return base.Deposit(interest);
        }



        public new bool Withdraw(double amount)
        {
            if (withdrawalsThisYear < 3 && amount <= 0.2 * GetBalance())
            {
                withdrawalsThisYear++;
                return base.Withdraw(amount);
            }
            return false;
        }
        

        public override string ToString()
        {
            return $"{base.ToString()},{interestRate}";
        }


    }

}
