﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class AccountUtil
    {
        // Utility helper functions for Account class

        public static void Display(List<Account> accounts)
        {
            Console.WriteLine("\n=== Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }

        // Helper functions for Savings Account class
        public static void Display(List<SavingsAccount> savAccounts)
        {
            Console.WriteLine("\n=== SavingsAccount ==========================================");
            foreach (var acc in savAccounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<SavingsAccount> savAccounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to SavingsAccount =================================");
            foreach (var acc in savAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<SavingsAccount> savAccounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from SavingsAccount ==============================");
            foreach (var acc in savAccounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }

        // Helper functions for Checking Account class
        public static void Display(List<CheckingAccount> checAccounts)
        {
            Console.WriteLine("\n=== CheckingAccount ==========================================");
            foreach (var acc in checAccounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<CheckingAccount> checAccounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to CheckingAccount =================================");
            foreach (var acc in checAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<CheckingAccount> checAccounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from CheckingAccount ==============================");
            foreach (var acc in checAccounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }

        // Helper functions for Trust account class
        public static void Display(List<TrustAccount> trustAccounts)
        {
            Console.WriteLine("\n=== TrustAccount ==========================================");
            foreach (var acc in trustAccounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<TrustAccount> trustAccounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to TrustAccount =================================");
            foreach (var acc in trustAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<TrustAccount> trustAccounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from TrustAccount ==============================");
            foreach (var acc in trustAccounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }
    }
}
