using System;
using System.Collections.Generic;
using System.Linq;

namespace vending_machine
{
    public class Customer
    {
        public int Money { get; private set; }

        private readonly List<Food> _foodCart;
        private readonly List<Drinks> _drinksCart;
        private readonly List<Snacks> _snacksCart;

        public Customer()
        {
            _foodCart = new List<Food>();
            _drinksCart = new List<Drinks>();
            _snacksCart = new List<Snacks>();
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

            _foodCart.Add(foodItem);
        }
        
        public void AddDrink(Drinks drinkItem)
        {
            if (drinkItem == null)
            {
                return;
            }

            _drinksCart.Add(drinkItem);
        }
        public void AddSnack(Snacks snackItem)
        {
            if (snackItem == null)
            {
                return;
            }

            _snacksCart.Add(snackItem);
        }

        public void CheckReceipt()
        {
            if (_foodCart.Count == 0 && _drinksCart.Count == 0 && _snacksCart.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou haven't bought anything!");
                Console.ResetColor();
                return;
            }
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***** RECEIPT *****");
            Console.ResetColor();
            foreach (var meal in _foodCart)
            {
                Console.WriteLine($"1X {meal.Name} - {meal.Price} SEK.");
            }
            foreach (var drink in _drinksCart)
            {
                Console.WriteLine($"1X {drink.Name} - {drink.Price} SEK.");
            }
            foreach (var snack in _snacksCart)
            {
                Console.WriteLine($"1X {snack.Name} - {snack.Price} SEK.");
            }

            var mealCost = _foodCart.Sum(p => p.Price);
            var drinkCost = _drinksCart.Sum(p => p.Price);
            var snackCost = _snacksCart.Sum(p => p.Price);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***** TOTAL *****");
            Console.ResetColor();
            Console.WriteLine($"{mealCost + drinkCost + snackCost} SEK");
        }
    }
}