using System;

namespace vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***** Welcome to the Virtual Vending Machine 2.19 ***** ");
            Console.ResetColor();

            var vendingMachine = new VendingMachine();
            var customer = new Customer();
            var atm = new Atm();

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Check Menu");
                Console.WriteLine("2. ATM");
                Console.WriteLine("3. Check Wallet For Cash");
                Console.WriteLine("4. Receipt");
                Console.WriteLine("5. Quit.");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n***** MENU *****");
                            Console.ResetColor();
                            
                            Console.WriteLine("1. Food");
                            Console.WriteLine("2. Drinks");
                            Console.WriteLine("3. Snacks");
                            Console.WriteLine("4. Go back");

                            var menuInput = Console.ReadLine();
                            
                            if (menuInput == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n***** FOOD *****");
                                Console.ResetColor();
                                vendingMachine.ShowFoodMenu();
                                Console.WriteLine("6. Go back.");
                                var foodInput = Console.ReadLine();
                                var foodItem = vendingMachine.BuyMeal(foodInput, customer.Money);

                                if (foodInput == "6" || foodItem == null)
                                {
                                    continue;
                                }

                                customer.RemoveMoney(foodItem.Price);
                                customer.AddMeal(foodItem);
                                
                                Console.WriteLine("\nWant to order something else?");
                                Console.WriteLine("1. Yes.");
                                Console.WriteLine("2. No");
                                var answer = Console.ReadLine();
                                
                                if (answer == "1")
                                {
                                    continue;
                                }

                                if (answer == "2")
                                {
                                    break;
                                }
                            }
                            
                            if (menuInput == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n***** DRINKS *****");
                                Console.ResetColor();
                                vendingMachine.ShowDrinksMenu();
                                Console.WriteLine("6. Go back");
                                var drinksInput = Console.ReadLine();
                                var drinkItem = vendingMachine.BuyDrink(drinksInput, customer.Money);

                                if (drinksInput == "6" || drinkItem == null)
                                {
                                    continue;
                                }

                                customer.RemoveMoney(drinkItem.Price);
                                customer.AddDrink(drinkItem);

                                Console.WriteLine("\nWant to order something else?");
                                Console.WriteLine("1. Yes.");
                                Console.WriteLine("2. No");
                                var answer = Console.ReadLine();

                                if (answer == "1")
                                {
                                    continue;
                                }

                                if (answer == "2")
                                {
                                    break;
                                }
                            }
                            
                            if (menuInput == "3")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n***** SNACKS *****");
                                Console.ResetColor();
                                vendingMachine.ShowSnacksMenu();
                                Console.WriteLine("6. Go back");
                                var snacksInput = Console.ReadLine();
                                var snackItem = vendingMachine.BuySnack(snacksInput, customer.Money);

                                if (snacksInput == "6" || snackItem == null)
                                {
                                    continue;
                                }

                                customer.RemoveMoney(snackItem.Price);
                                customer.AddSnack(snackItem);

                                Console.WriteLine("\nWant to order something else?");
                                Console.WriteLine("1. Yes.");
                                Console.WriteLine("2. No");
                                var answer = Console.ReadLine();

                                if (answer == "1")
                                {
                                    continue;
                                }

                                if (answer == "2")
                                {
                                    break;
                                }
                            }

                            if (menuInput == "4")
                            {
                                break;
                            }
                            
                        }
                        break;
                    
                    case "2":
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n***** ATM *****");
                            Console.ResetColor();
                            
                            Console.WriteLine("1. Show current balance.");
                            Console.WriteLine("2. Withdraw Money");
                            Console.WriteLine("3. Deposit Money");
                            Console.WriteLine("4. Go back");

                            var bankInput = Console.ReadLine();

                            if (bankInput == "1")
                            {
                                atm.ShowBalance();
                                continue;
                            }

                            if (bankInput == "2")
                            {
                                atm.ShowBalance();
                                Console.WriteLine("How much would you like want to withdraw?");
                                int.TryParse(Console.ReadLine(), out int amount);
                                var money = atm.Withdraw(amount);
                                customer.AddMoney(money);
                                continue;
                            }

                            if (bankInput == "3")
                            {
                                Console.WriteLine($"\nYou currently carry {customer.Money} SEK.");
                                Console.WriteLine("How much would you like want to deposit?");
                                int.TryParse(Console.ReadLine(), out int amount);

                                if (customer.Money < amount)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nYou have insufficient funds.");
                                    Console.ResetColor();
                                    continue;
                                }
                                var money = atm.Deposit(amount);
                                customer.RemoveMoney(money);
                                continue;
                            }

                            if (bankInput == "4")
                            {
                                break;
                            }
                        }
                        break;
                    
                    case "3": 
                        if (customer.Money == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYour wallet is empty.");
                            Console.ResetColor();
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nYou currently have {customer.Money} SEK.");
                        Console.ResetColor();
                        break;
                    
                    case "4":
                        customer.CheckReceipt();
                        break;
                    
                    case "5":
                        Console.WriteLine("\nThank you for using the Virtual Vending Machine 2.19");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Shutting down...");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}