namespace Bai6
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public new string ProduceSound()
        {
            return "Woof!";
        }
    }

    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public new string ProduceSound()
        {
            return "Ribbit";
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        
        }

        public new string ProduceSound()
        {
            return "Meow meow";
        }
    }

    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, "Female")
        {

        }
        public new string ProduceSound()
        {
            return "Meow";
        }
    }

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, "Male")
        {

        }
        public new string ProduceSound()
        {
            return "MEOW";
        }
    }
}