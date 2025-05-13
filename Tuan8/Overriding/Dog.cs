namespace Overriding
{
    public class Dog: Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine($"Dogs speaks gau gau");
        }
    }
}