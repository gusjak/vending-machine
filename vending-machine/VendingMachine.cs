using System;
using System.Collections.Generic;

namespace vending_machine
{
    public class VendingMachine
    {
        private readonly List<Food> FoodMenu = new List<Food>
        {
            new Food("Kebab Pizza", 100),
            new Food("Bacon & Cheeseburger", 75),
            new Food("Quesadilla", 95),
            new Food("Mama's Sushi 12x", 135),
            new Food("Spring Rolls", 80),
        };
        
        private readonly List<Drinks> DrinksMenu = new List<Drinks>
        {
            new Drinks("Coca Cola", 15),
            new Drinks("Fanta", 15),
            new Drinks("Sprite", 15),
            new Drinks("Sparkling Water", 10),
            new Drinks("Tap Water", 0),
        };
        
        private readonly List<Snacks> SnacksMenu = new List<Snacks>
        {
            new Snacks("Chips", 15),
            new Snacks("Snickers", 10),
            new Snacks("Twix", 10),
            new Snacks("Peanuts", 20),
            new Snacks("Müslibar", 20),
        };

        public void ShowFoodMenu()
        {
            var index = 1;
            foreach (var item in FoodMenu)
            {
                Console.WriteLine($"{index++}. {item.Name}, {item.Price} SEK.");
            }
        }
        
        public void ShowDrinksMenu()
        {
            var index = 1;
            foreach (var item in DrinksMenu)
            {
                Console.WriteLine($"{index++}. {item.Name}, {item.Price} SEK.");
            }
        }
        
        public void ShowSnacksMenu()
        {
            var index = 1;
            foreach (var item in SnacksMenu)
            {
                Console.WriteLine($"{index++}. {item.Name}, {item.Price} SEK.");
            }
        }
        
        public Food BuyMeal(string input, int money)
        {
            int.TryParse(input, out int number);

            if (number > 5 || number < 1)
            {
                return null;
            }

            var selectedMeal = FoodMenu[number - 1];

            if (selectedMeal.Price > money)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou don't have enough money to buy this.");
                Console.ResetColor();
                return null;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYou have selected {selectedMeal.Name}, that'll be {selectedMeal.Price} SEK.");
            Console.ResetColor();
            return selectedMeal;
        }
        
        public Drinks BuyDrink(string input, int money)
        {
            int.TryParse(input, out int number);

            if (number > 5 || number < 1)
            {
                return null;
            }

            var selectedDrink = DrinksMenu[number - 1];

            if (selectedDrink.Price > money)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou don't have enough money to buy this.");
                Console.ResetColor();
                return null;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYou have selected {selectedDrink.Name}, that'll be {selectedDrink.Price} SEK.");
            Console.ResetColor();
            return selectedDrink;
        }
        
        public Snacks BuySnack(string input, int money)
        {
            int.TryParse(input, out int number);

            if (number > 5 || number < 1)
            {
                return null;
            }

            var selectedSnack = SnacksMenu[number - 1];

            if (selectedSnack.Price > money)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou don't have enough money to buy this.");
                Console.ResetColor();
                return null;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYou have selected 1X {selectedSnack.Name}, that'll be {selectedSnack.Price} SEK.");
            Console.ResetColor();
            return selectedSnack;
        }
    }
}