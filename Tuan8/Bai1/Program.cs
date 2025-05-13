namespace Bai1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Name: ");
        string name=Console.ReadLine();
        System.Console.WriteLine("Age: ");
        int age= int.Parse(Console.ReadLine());
        Child child= new Child(name, age);
        child.Xuat();
    }
}
