using System.Security.Cryptography.X509Certificates;

namespace Bai2
{
    public class Mammal: Animal
    {
        public double Height{ get; set; }
        public Mammal (string name, double height): base (name)
        {
            this.Height = height;
        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Name} is Mammal, height: {Height}m");
        }
    }
    public class Gorilla: Mammal
    {
        public Gorilla (string name, double height): base (name, height)
        {

        }
        public new void Xuat()
        {
            base.Xuat ();
            System.Console.WriteLine($"{Name} is Gorilla");
        }
    }
    public class Bear: Mammal
    {
        public Bear (string name, double height): base(name, height)
        {

        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Name} is Bear");
        }
    }
}