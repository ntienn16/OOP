namespace Bai2_classroom
{
    public class Cat: Animal
    {
        public string Name{get;set;}
        public Cat(string name): base("Mammal")
        {
            Name=name;
        }
        public override string MakeSound()
        {
            return "Meow";
        }
        public override string GetInfo()
        {
            return $"Cat name: {Name}, type: {Type}";
        }
        public void Climb(string objectClimb)
        {
            System.Console.WriteLine($"{Name} is climbing the {objectClimb}");
        }
    }
}