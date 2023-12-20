﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Part1
{
    internal class Account
    {
        private decimal Balance;
        private string name;
        public Account(string name, decimal staringBalance)
        {
            name = name;
            Balance = staringBalance;
        }
        public bool Deposit(decimal amountToDeposit)
        {
            if (amountToDeposit > 0)
            {
                Balance += amountToDeposit;
                return true;
            }
            return false;

        }
        public bool Withdraw(decimal amount)
        {
            if (amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Name
        {

            get { return name; }
        }
        public void Print()
        {
            Console.WriteLine($"Current Name: {name}");
            Console.WriteLine($"Account Balance: ${Balance}");
        }
    }
}

