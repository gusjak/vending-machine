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
                Console.WriteLine($"\nYou have withdrawn all your life savings already.");
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
            Account += amount;
            return amount;
        }

        public void ShowBalance()
        {
            if (Account == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou have nothing left in your account.");
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