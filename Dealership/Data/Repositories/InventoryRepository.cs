using System;
using System.Collections.Generic;
using System.Linq;
using Dealership.Models;

namespace Dealership.Data.Repositories
{
    public class InventoryRepository
    {
        public static List<Inventory> Database = new List<Inventory>
        {
            new Car {Id = 1, Name = "Honda Accord 2003", Price = 22000m, Broken = true},
            new Boat {Id = 2, Name = "Fancy Yacht", Price = 5000000m},
            new Truck {Id = 3, Name = "Toyota Tundra", Price = 35000m},
            new Motorcycle {Id = 4, Name = "Kawasaki Ninja", Price = 25000},
            new Car {Id = 5, Name = "Toyota Corolla", Price = 10000m},
            new Truck {Id = 6, Name = "Ford F150", Price = 60000m},
            new Car {Id = 7, Name = "Volkswagon Tiguan", Price = 30000m}
        };

        public List<Inventory> GetAll()
        {
            return Database;
        }

        public Inventory GetById(int id)
        {
            return Database.SingleOrDefault(x => x.Id == id);
        }

        public static decimal Balance { get; set; }
        
        public static void GetBalance()
        {
            if (Balance > 50000)
            {
                Console.WriteLine("Your balance is: ${0}. You're doing great! Press any key to continue...", Balance);
            }
            else
            {
                Console.WriteLine("Your balance is: ${0}. You're not doing too well, brah. Press any key to continue...", Balance);
            }
            
        }

        static InventoryRepository()
        {
            Balance = 100000m;
        }

        public void Sell(int id)
        {
            var a = GetById(id);

            Console.WriteLine("You are trying to sell a {0}", a.Name);
            
  
            if (Database.Contains(a))
            {
                Database.Remove(a);
                Balance += a.Price;
                Console.WriteLine("Sold!");
                if (Database.Count == 0)
                {
                    Console.WriteLine("Now your inventory is empty.");
                }
                else
                {
                    Console.WriteLine("Your inventory now contains the following:");
                    foreach (var i in Database)
                    {
                        Console.WriteLine(i.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("You can't sell something you don't have, idiot.");
            }

            Database.Remove(a);

            GetBalance();          
        }

        public Inventory Buy(Inventory inventory)
        {

            Console.WriteLine("You are trying to buy a {0}", inventory.Name);
            if (Balance >= inventory.Price)
            {
                Database.Add(inventory);
                Balance -= inventory.Price;
                Console.WriteLine("Sweet! Your inventory now contains the following:");
                foreach (var i in Database)
                {
                    Console.WriteLine(i.Name);
                }    
            }
            else
            {
                Console.WriteLine("You have insufficient funds to complete this transaction. Too bad!");                
            }
            
            GetBalance();
            return inventory;
        }

        public void Repair(int id)
        {
            var brokenInventory = GetById(id);
            var larry = new Mechanic();
            larry.Repair(brokenInventory);
        }
    }
    
}
