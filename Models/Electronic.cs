using vendmach.Interfaces;

namespace vendmach.Models
{
    class Electronic : IPurchasable
    {
        public string Name { get; set; }

        public float Price { get; set; }
        public int Quantity { get; set; }

        public float GetPrice(int q)
        {
            return Price * q;
        }
        public Electronic(string name, float price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}


