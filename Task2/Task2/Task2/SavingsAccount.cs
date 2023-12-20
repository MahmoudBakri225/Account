using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public class SavingsAccount : Account
    {
        private double interestRate;

        public SavingsAccount(string name = "Unnamed Savings Account", double balance = 0.0, double interestRate = 1.0)
            : base(name, balance)
        {
            this.interestRate = interestRate;
        }

        public new bool Deposit(double amount)
        {
            double interest = amount * (interestRate / 100); // Calculate interest
            return base.Deposit(amount + interest);
        }

        public override string ToString()
        {
            return  $"{base.ToString()},{interestRate}";
        }

    }
}
