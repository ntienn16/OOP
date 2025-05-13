namespace Bai4
{
    public class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption { get; set; } = 1.25;
        public double FuelConsumption { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            FuelConsumption = DefaultFuelConsumption;
        }

        public void Drive(double kilometers)
        {
            double fuelNeeded = kilometers * FuelConsumption;
            if (Fuel >= fuelNeeded)
            {
                Fuel = Fuel - fuelNeeded;
                System.Console.WriteLine($"Xang con lai: {Fuel}");
            }
            else
            {
                Console.WriteLine("Khong du xang");
            }
        }
    }
}