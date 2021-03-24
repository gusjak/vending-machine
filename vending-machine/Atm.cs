using System;

namespace vending_machine
{
    public class Atm
    {
        private int Account { get; set; }

        public Atm()
        {
            Account = 1000;
        }

        public int Withdraw(int amount)
        {
            if (Account < amount)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nUnfortunately, you only have {Account} SEK in your account.");
                Console.ResetColor();
                return 0;
            }

            Account -= amount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSuccessfully withdrew {amount} SEK from your account.");
            Console.ResetColor();
            return amount;
        }

        public int Deposit(int amount)
        {
            if (amount < Account)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou don't have enough money to make this deposit.");
                Console.ResetColor();
                return 0;
            }
            
            Account += amount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSuccessfully deposited {amount} SEK to your account.");
            Console.ResetColor();
            return amount;
        }

        public void ShowBalance()
        {
            if (Account == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nUnfortunately, you only have {Account} SEK in your account.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou have {Account} SEK in your account.");
                Console.ResetColor();
            }
        }
    }
}