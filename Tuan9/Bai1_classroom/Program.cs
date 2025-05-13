namespace Bai1_classroom;

class Program
{
    static void Main(string[] args)
    {
        Line line = new Line(0, 0, 1, 1);
        line.Show();
        Console.WriteLine(line.ToString());

        Circle circle = new Circle(2, 2, 5);
        circle.Show();
        Console.WriteLine(circle.ToString());

        Rectangle rectangle = new Rectangle(0, 0, 2, 0, 2, 3);
        rectangle.Show();
        Console.WriteLine(rectangle.ToString());
    }
}
