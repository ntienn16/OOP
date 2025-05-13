namespace Bai4
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 8;
            FuelConsumption = DefaultFuelConsumption;
        }
    }
    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
    }
}