namespace vending_machine
{
    public class Food
    {
        public string Name { get; }
        public int Price { get; }

        public Food(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}