namespace Bai3
{
    public class Circle: Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Perimeter()
        {
            return 2*PI*Radius;
        }
        public override double Area()
        {
            return PI*Radius*Radius;
        }
        public override string ToString()
        {
            return $"Circle: radius= {Radius}, Perimeter= {Perimeter()}, Area= {Area()}";
        }
    }
}