using System;

class Animal
{
    public string Name { get; set; }

    // Base class constructor
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine("Animal constructor called.");
    }
}

class Dog : Animal
{
    public string Breed { get; set; }

    // Calling base class constructor using base()
    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
        Console.WriteLine("Dog constructor called.");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog("Buddy", "Labrador");
        Console.WriteLine("Name: "+myDog.Name+", Breed: "+myDog.Breed);
    }
}
