namespace Bai1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set;}
        public Person (string name, int age)
        {
            this.Name = name;
            if (age > 0)
            {this.Age = age;}
        }
        public void Xuat()
        {
            System.Console.WriteLine($"Name: {Name}, age: {Age}");
        }
    }
}