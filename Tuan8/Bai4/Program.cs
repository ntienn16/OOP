namespace Bai4;

class Program
{
        static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle(100, 50);
        Console.WriteLine("Vehicle:");
        Console.WriteLine($"Xang ban dau: {vehicle.Fuel}");
        vehicle.Drive(10); 
        Console.WriteLine($"Xang con lai sau 10km: {vehicle.Fuel}");

        Car car = new Car(150, 50);
        Console.WriteLine("\nCar:");
        Console.WriteLine($"Xang ban dau: {car.Fuel}");
        car.Drive(10);
        Console.WriteLine($"Xang con lai sau 10 km: {car.Fuel}");

        RaceMotorcycle raceMotorcycle = new RaceMotorcycle(200, 50);
        Console.WriteLine("\nRaceMotorcycle:");
        Console.WriteLine($"Xang ban dau: {raceMotorcycle.Fuel}");
        raceMotorcycle.Drive(10); 
        Console.WriteLine($"Xang con lai sau 10 km: {raceMotorcycle.Fuel}");

        CrossMotorcycle crossMotorcycle = new CrossMotorcycle(150, 50);
        Console.WriteLine("\nCrossMotorcycle:");
        Console.WriteLine($"Xang ban dau: {crossMotorcycle.Fuel}");
        crossMotorcycle.Drive(10); 
        Console.WriteLine($"Xang con lai sau 10 km: {crossMotorcycle.Fuel}");

        FamilyCar familyCar = new FamilyCar(120, 50);
        Console.WriteLine("\nFamilyCar:");
        Console.WriteLine($"Xang ban dau: {familyCar.Fuel}");
        familyCar.Drive(10); 
        Console.WriteLine($"Xang con lai sau 10 km: {familyCar.Fuel}");

        SportCar sportCar = new SportCar(300, 50);
        Console.WriteLine("\nSportCar:");
        Console.WriteLine($"Xang ban dau: {sportCar.Fuel}");
        sportCar.Drive(10);
        Console.WriteLine($"Xang con lai 10 km: {sportCar.Fuel}");
    }
}
