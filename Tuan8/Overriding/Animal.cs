namespace Overriding
{
    public class Animal
    {
        public string Name { get; set; }
        public void Print()
        {
            System.Console.WriteLine($"Animal has name: {Name}");
        }
    }
}
