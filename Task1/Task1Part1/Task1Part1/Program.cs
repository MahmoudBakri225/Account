using System;

namespace Task1Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Account");
            Console.WriteLine("------------");
            Account account1 = new Account("Jakes",2000000);
            account1.Print();
            Console.WriteLine("**************************");
            account1.Deposit(100);
            account1.Print();
            Console.WriteLine("**************************");
            account1.Withdraw(100);
            account1.Print();
            Console.WriteLine("**************************");
            Console.WriteLine("Second Account");
            Console.WriteLine("--------------");
            Account account2 = new Account("Mahmoud", 10000);
            account2.Print();
            Console.WriteLine("***********************");
            account2.Deposit(1000);
            account2.Print();
            Console.WriteLine("***********************");
            account2.Withdraw(500);
            account2.Print();
            Console.WriteLine("***********************");






        }
    }
}