namespace Bai2_classroom
{
    public class Duck:Animal
    {
        public string Name{get;set;}
        public Duck(string name):base("Bird")
        {
            Name=name;
        }
        public override string MakeSound()
        {
            return "Quack";
        }
        public override string GetInfo()
        {
            return $"Duck name: {Name}, type: {Type}";
        }
        public void Swim(string placeSwim)
        {
            Console.WriteLine($"{Name} is swimming in {placeSwim}");
        }
    }
}