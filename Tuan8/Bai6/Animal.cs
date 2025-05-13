namespace Bai6
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Animal(string name, int age, string gender)
        {
            if (string.IsNullOrWhiteSpace(name) || age < 0 || string.IsNullOrWhiteSpace(gender))
            {
                System.Console.WriteLine("Invalid Input");
            }
            else
            {
                Name = name;
                if (age > 0)
                {Age = age;}
                Gender = gender;
            }
        }
        public string ProduceSound()
        {
            return "";
        }
    }
}