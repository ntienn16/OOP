namespace Bai4
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 3;
            FuelConsumption = DefaultFuelConsumption;
        }
    }
    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        
        }
    }
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 10;
            FuelConsumption = DefaultFuelConsumption;
        }
    }
}