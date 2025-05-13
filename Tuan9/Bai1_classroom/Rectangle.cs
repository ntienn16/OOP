namespace Bai1_classroom
{
    public class Rectangle:Shape
    {
        private float x2;
        private float y2;
        private float x3;
        private float y3;
        public Rectangle(float x1, float y1, float x2, float y2, float x3, float y3): base(x1,y1)
        {
            this.x2=x2;
            this.y2=y2;
            this.x3=x3;
            this.y3=y3;
        }
        public override void Show()
        {
            System.Console.WriteLine($"Rectangle with vertices ({x},{y}, ({x2},{y2}), ({x3},{y3})");
        }
        public override string ToString()
        {
            return $"Rectangle: vertex1 {x},{y}; vertex2 {x2},{y2}; vertex3 {x3},{y3}";
        }
    }
}