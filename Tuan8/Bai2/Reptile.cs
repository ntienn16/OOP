using System.Security.Cryptography.X509Certificates;

namespace Bai2
{
    public class Reptile: Animal
    {
        public string Colour { get; set; }
        public Reptile(string name, string colour): base(name)
        {
            this.Colour=colour;
        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Name} is Retile, has colour: {Colour}");
        }
    }
    public class Lizard: Reptile
    {
        public Lizard (string name, string colour): base(name, colour)
        {

        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Name} is Lizard");
        }
    }
    public class Snake: Reptile
    {
        public Snake (string name, string colour): base (name, colour)
        {

        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Name} is Snake");
        }
    }
}