namespace Bai1_classroom
{
    public abstract class Shape
    {
        protected float x;
        protected float y;
        public Shape(float x, float y)
        {
            this.x=x;
            this.y=y;
        }
        public void Move(float moveX, float moveY)
        {
            x=x+moveX;
            y=y+moveY;
        }
        public abstract void Show();
        public abstract override string ToString();
    }
}