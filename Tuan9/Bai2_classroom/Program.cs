namespace Bai2_classroom;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Dog1", "Chihuahua");
        Console.WriteLine(dog.GetInfo());
        Console.WriteLine($"Sound: {dog.MakeSound()}");

        Cat cat = new Cat("Cat1");
        System.Console.WriteLine(cat.GetInfo());
        System.Console.WriteLine($"Sound {cat.MakeSound()}");
        cat.Climb("tree");

        Duck duck=new Duck("Duck1");
        System.Console.WriteLine(duck.GetInfo());
        System.Console.WriteLine($"Sound: {duck.MakeSound()}");
        duck.Swim("pond");
    }
}
