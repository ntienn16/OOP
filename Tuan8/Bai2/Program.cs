namespace Bai2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Name: ");
        string name1=Console.ReadLine();
        System.Console.WriteLine("Colour: ");
        string colour1= Console.ReadLine();
        Snake snake=new Snake(name1,colour1);
        snake.Xuat();

        System.Console.WriteLine("\nName: ");
        string name2=Console.ReadLine();
        System.Console.WriteLine("Height: ");
        double height2=double.Parse(Console.ReadLine());
        Gorilla gorilla=new Gorilla(name2,height2);
        gorilla.Xuat(); 
    }
}
