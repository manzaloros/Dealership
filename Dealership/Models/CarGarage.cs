using System;

namespace Dealership.Models
{
    public static class CarGarage
    {
        public static Mechanic Tubby = new Mechanic();

        public static void Repair(Car car)
        {
            Console.WriteLine("Tubby is repairing your {0}.", car.Name);
            Tubby.Repair(car);
            Console.ReadKey();
        }

        public static void Repair(Truck truck)
        {
            Tubby.Repair(truck);
        }
    }
}
