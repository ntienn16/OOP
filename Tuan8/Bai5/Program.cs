namespace Bai5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Coffee:");
        Coffee coffee = new Coffee("Espresso", 95.0); 
        Console.WriteLine($"Name: {coffee.Name}");
        Console.WriteLine($"Price: {coffee.Price}");
        Console.WriteLine($"Milliliters: {coffee.Milliliters}");
        Console.WriteLine($"Caffeine: {coffee.Caffeine}");

        Console.WriteLine("\nTea:");
        Tea tea = new Tea("Green Tea", 2.5m, 200); 
        Console.WriteLine($"Name: {tea.Name}");
        Console.WriteLine($"Price: {tea.Price}");
        Console.WriteLine($"Milliliters: {tea.Milliliters}");

        Console.WriteLine("\nCake:");
        Cake cake = new Cake("Chocolate Cake");
        Console.WriteLine($"Name: {cake.Name}");
        Console.WriteLine($"Price: {cake.Price}");
        Console.WriteLine($"Grams: {cake.Grams}");
        Console.WriteLine($"Calories: {cake.Calories}");

        Console.WriteLine("\nFish:");
        Fish fish = new Fish("Salmon", 12.99m); 
        Console.WriteLine($"Name: {fish.Name}");
        Console.WriteLine($"Price: {fish.Price}");
        Console.WriteLine($"Grams: {fish.Grams}");
    }
}
