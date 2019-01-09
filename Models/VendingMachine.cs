using System.Collections.Generic;
using vendmach.Interfaces;

namespace vendmach.Models
{
    public class VendMachine
    {
        public float Money { get; set; }
        public Dictionary<string, IPurchasable> Inventory { get; private set; }

        public VendMachine(float money)
        {
            Money = money;
            Inventory = new Dictionary<string, IPurchasable>();
        }
        public void AddQuarter(float quarter)
        {
            Money += .25f;
        }
        public void PrintInventory()
        {
            foreach (var pair in Inventory)
            {
                System.Console.WriteLine($"{pair.Key}: {pair.Value.Name} - Price: {pair.Value.Price} Quanitity: {pair.Value.Quantity}");
            }
        }
        public void PrintMoney()
        {
            System.Console.WriteLine($"Money in Machine: {Money}");
        }
        // public void AddItem(IPurchasable item, string location)
        // {
        //     if (!Inventory.ContainsKey(location))
        //     {
        //         Inventory.Add(location, item);
        //     }
        // }

    }
}