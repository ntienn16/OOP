namespace Bai1
{
    public class Child: Person
    {
        public Child (string name, int age): base(name, age)
        {
            if (Age > 15)
            {
                System.Console.WriteLine("Tuoi cua tre be hon 15");
            }
        }
        public new void Xuat()
        {
            base.Xuat();
        }
    }
}