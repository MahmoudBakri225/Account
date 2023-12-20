using System.Security.Principal;

namespace Task1Part2
{
    public enum MenuOption
    {
        Withdraw,
        Deposit,
        Print,
        Quit
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your Name:");
            Account userAccount = new Account("Mahmoud", 0);

            do
            {
                MenuOption userChoice = ReadUserOption(userAccount);

                switch (userChoice)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(userAccount);
                        break;
                    case MenuOption.Deposit:
                        DoDeposit(userAccount);
                        break;
                    case MenuOption.Print:
                        DoPrint(userAccount);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("You selected Quit.");
                        break;
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            } while (true);

        }
        static MenuOption ReadUserOption(Account account)
        {
            MenuOption userChoice;
            int choice;

            do
            {
                Console.WriteLine("-------------");
                Console.WriteLine("0. Withdraw");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Print");
                Console.WriteLine("3. Quit");
                Console.WriteLine("Choose An Option:"); ;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    userChoice = (MenuOption)(-1);

                }
                else
                {
                    userChoice = (MenuOption)choice;
                }

            } while (userChoice < MenuOption.Withdraw || userChoice > MenuOption.Quit);

            return userChoice;
        }
        static void DoDeposit(Account account)
        {
            Console.WriteLine("Enter the deposit amount:");
            decimal amount;

            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
            account.Deposit(amount);
            
        }

        static void DoWithdraw(Account account)
        {
            Console.WriteLine("Enter the withdrawal amount:");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
            account.Withdraw(amount);
            
        }

        static void DoPrint(Account account)
        {
            account.PrintBalance();
        }

    }
}