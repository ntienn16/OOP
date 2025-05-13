namespace Bai1_classroom
{
    public class Circle:Shape
    {
        private float radius;
        public Circle(float x, float y, float radius):base(x,y)
        {
            this.radius=radius;
        }
        public override void Show()
        {
            System.Console.WriteLine($"Circle at {x},{y} with radius {radius}");

        }
        public override string ToString()
        {
            return $"Circle: center {x}, {y}; radius {radius}";
        }
    }
}