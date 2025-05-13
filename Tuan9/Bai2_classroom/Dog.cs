namespace Bai2_classroom
{
    public class Dog:Animal
    {
        public string Name{get;set;}
        public string Breed{get;set;}
        public Dog(string name, string breed): base("Mammal")
        {
            Name=name;
            Breed=breed;
        }
        public override string MakeSound()
        {
            return "Woof";
        }
        public override string GetInfo()
        {
            return $"Dog name: {Name}, breed: {Breed}, type: {Type}";
        }
    }
}