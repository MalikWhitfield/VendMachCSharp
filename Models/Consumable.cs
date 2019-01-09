using vendmach.Interfaces;

namespace vendmach.Models
{
    abstract class Consumable
    {
        public int Calories { get; set; }

        public Consumable(int calories)
        {
            Calories = calories;
        }
    }
}