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

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Check Menu");
                Console.WriteLine("2. ATM");
                Console.WriteLine("3. Check Wallet For Cash");
                Console.WriteLine("4. Check Receipt");
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

                                if (foodInput == "6")
                                {
                                    continue;
                                }
                                
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

                                if (drinksInput == "6")
                                {
                                    continue;
                                }

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

                                if (snacksInput == "6")
                                {
                                    continue;
                                }

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
                            
                            Console.WriteLine("How may I be of service?");
                            Console.WriteLine("1. Show current balance.");
                            Console.WriteLine("2. Withdraw Money");
                            Console.WriteLine("3. Deposit Money");
                            Console.WriteLine("4. Go back");

                            var bankInput = Console.ReadLine();

                            if (bankInput == "1")
                            {
                                Console.WriteLine("\nYou currently have X SEK.");
                                continue;
                            }

                            if (bankInput == "2")
                            {
                                Console.WriteLine("\nHow much would you like want to withdraw?");
                                continue;
                            }

                            if (bankInput == "3")
                            {
                                Console.WriteLine("\nHow much would you like want to deposit?");
                                continue;
                            }

                            if (bankInput == "4")
                            {
                                break;
                            }
                        }
                        break;
                    
                    case "3": 
                        Console.WriteLine("\nYou currently have X SEK.");
                        break;
                    
                    case "4":
                        Console.WriteLine("\nYou have bought X items.");
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