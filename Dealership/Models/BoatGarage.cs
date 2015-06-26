namespace Dealership.Models
{
    public static class BoatGarage
    {
        public static Mechanic Larry = new Mechanic();

        public static void Repair(Boat boat)
        {
            Larry.Repair(boat);
        }
    }
}
