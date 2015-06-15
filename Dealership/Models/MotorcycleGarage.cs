namespace Dealership.Models
{
    public static class MotorcycleGarage
    {
        public static Mechanic Joe = new Mechanic();

        public static void Repair(Motorcycle motorcycle)
        {
            Joe.Repair(motorcycle);
        }
    }
}
