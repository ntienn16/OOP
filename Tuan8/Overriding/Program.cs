﻿namespace Overriding;

class Program
{
    static void Main(string[] args)
    {
        Animal animal= new Animal();
        animal.Name = "ABC";
        animal.Print();
        System.Console.WriteLine(animal);
    }
}
