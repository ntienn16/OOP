namespace Bai3
{
    public class Rectangle: Shape
    {
        public double Weight{ get; set; }
        public double Height{ get; set; }
        public Rectangle(double Weight, double Height)
        {
            this.Weight = Weight;
            this.Height = Height;
        }
        public override double Perimeter()
        {
            return (Weight+Height)*2;
        }
        public override double Area()
        {
            return Weight*Height;
        }
        public override string ToString()
        {
            return $"Rectangle: Weight= {Weight}, Height= {Height}, Perimeter= {Perimeter()}, Area= {Area()}";
        }
    }
}