using System;
using vendmach.Models;

namespace vendmach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Vending Machine");

            VendMachine myVending = new VendMachine(10f);
            #region 
            Beverage coke = new Beverage("Coke", 1.5f, 5, 800);
            Beverage sprite = new Beverage("McDonald's Sprite", 20f, 1, 1);
            Food chexmix = new Food("Chexmix", 1.25f, 4, 400);
            Food riceKrispy = new Food("Rice Krispy", .85f, 5, 1200);
            Electronic alexa = new Electronic("Alexa", .25f, 100);
            Electronic airpods = new Electronic("AirPods", 150f, 100);
            myVending.Inventory.Add("A1", coke);
            myVending.Inventory.Add("A2", sprite);
            myVending.Inventory.Add("B3", riceKrispy);
            myVending.Inventory.Add("B4", chexmix);
            myVending.Inventory.Add("C5", alexa);
            myVending.Inventory.Add("C6", airpods);
            #endregion
            myVending.PrintInventory();
            myVending.PrintMoney();
            System.Console.WriteLine("What you tryna buy, fool?");
            string selection = Console.ReadLine();
            // public Dictionary<string, List<Beverage>> Bevarage { get; private set; }
            // // public List<IPurchasable> Inventory {get; set;}
            foreach (var pair in myVending.Inventory)
            {
                if (selection == pair.Key)
                {
                    pair.Value.Quantity = pair.Value.Quantity - 1;
                }
            }
            foreach (var pair in myVending.Inventory)
            {
                System.Console.WriteLine($"{pair.Key}: {pair.Value.Name} - Price: {pair.Value.Price} Quanitity: {pair.Value.Quantity}");
            }
        }
    }
}
