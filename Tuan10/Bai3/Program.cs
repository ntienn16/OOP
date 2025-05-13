namespace Bai3;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle(5));
        shapes.Add(new Circle(6));
        shapes.Add(new Rectangle(4, 6));
        shapes.Add(new Rectangle(3, 4));

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}
