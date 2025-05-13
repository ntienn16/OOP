namespace Bai2
{
    public class Animal
    {
        public string Name { get; set; }
        public Animal (string name)
        {
            this.Name = name;
        }
        public void Xuat()
        {
            System.Console.WriteLine($"Animal has name: {Name}");
        }
    }
}
