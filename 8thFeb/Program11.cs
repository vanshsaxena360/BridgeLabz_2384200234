using System;

// Base class
class Animal
{
    public string Name { get; set; }

    public void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Derived class inheriting from Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine(Name + " barks");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Name = "Buddy";

        myDog.Speak(); // Inherited method
        myDog.Bark();  // Dog-specific method
    }
}
