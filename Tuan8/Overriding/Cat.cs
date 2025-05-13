namespace Overriding
{
    public class Cat: Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Cats speak meow");
        }
    }
}