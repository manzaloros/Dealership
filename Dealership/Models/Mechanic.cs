using System;

namespace Dealership.Models
{
    public class Mechanic
    {
        public void Repair(Inventory inventory)
        {
            
            if (inventory.Broken)
            {
                inventory.Price *= 1.2m;
                inventory.Broken = false;
                Console.WriteLine("Success! The {0} is now worth ${1} Press any key to continue...", inventory.Name, inventory.Price);
            }
            else
            {
                Console.WriteLine("This item isn't broken.");
            }
        }
    }
}
