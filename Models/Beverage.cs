using vendmach.Interfaces;

namespace vendmach.Models
{
    class Beverage : Consumable, IPurchasable
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public float GetPrice(int q)
        {
            throw new System.NotImplementedException();
        }
        public Beverage(string name, float price, int quantity, int calories) : base(calories)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Calories = calories;
        }
    }
}