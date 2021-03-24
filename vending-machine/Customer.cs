using System;
using System.Collections.Generic;
using System.Linq;

namespace vending_machine
{
    public class Customer
    {
        public int Money { get; private set; }

        public List<Food> foodCart;
        public List<Drinks> drinksCart;
        public List<Snacks> snacksCart;

        public Customer()
        {
            foodCart = new List<Food>();
            drinksCart = new List<Drinks>();
            snacksCart = new List<Snacks>();
        }

        public void AddMoney(int amount)
        {
            Money += amount;
        }

        public void RemoveMoney(int amount)
        {
            Money -= amount;
        }

        public void AddMeal(Food foodItem)
        {
            if (foodItem == null)
            {
                return;
            }

            foodCart.Add(foodItem);
        }
        
        public void AddDrink(Drinks drinkItem)
        {
            if (drinkItem == null)
            {
                return;
            }

            drinksCart.Add(drinkItem);
        }
        public void AddSnack(Snacks snackItem)
        {
            if (snackItem == null)
            {
                return;
            }

            snacksCart.Add(snackItem);
        }

        public void CheckReceipt()
        {
            if (foodCart.Count == 0 && drinksCart.Count == 0 && snacksCart.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou haven't bought anything!");
                Console.ResetColor();
                return;
            }
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***** RECEIPT *****");
            Console.ResetColor();
            foreach (var meal in foodCart)
            {
                Console.WriteLine($"1X {meal.Name} - {meal.Price} SEK.");
            }
            foreach (var drink in drinksCart)
            {
                Console.WriteLine($"1X {drink.Name} - {drink.Price} SEK.");
            }
            foreach (var sideorder in snacksCart)
            {
                Console.WriteLine($"1X {sideorder.Name} - {sideorder.Price} SEK.");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***** TOTAL *****");
            Console.ResetColor();
            Console.WriteLine(
                $"{foodCart.Sum(p => p.Price) + drinksCart.Sum(p => p.Price) + snacksCart.Sum(p => p.Price)} SEK");
        }
    }
}