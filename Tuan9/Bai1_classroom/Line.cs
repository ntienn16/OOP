namespace Bai1_classroom
{
    public class Line:Shape
    {
        private float lineX;
        private float lineY;
        public Line(float x1, float y1, float lineX, float lineY): base(x1,y1)
        {
            this.lineX=lineX;
            this.lineY=lineY;
        }
        public override void Show()
        {
            System.Console.WriteLine($"Line from {x}, {y} to {lineX}, {lineY}");;
        }
        public override string ToString()
        {
            return $"Line: start {x}, {y}; end {lineX}, {lineY}";
        }
    }
}