namespace Bai2_classroom
{
    public abstract class Animal
    {
        protected string Type;
        public Animal(string type)
        {
            Type = type;
        }
        public abstract string MakeSound();
        public abstract string GetInfo();
    }
}