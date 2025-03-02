using System;

class Animal
{
    public void Speak()  // Regular method (not virtual, so no need to override)
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public void Bark()  // Additional behavior specific to Dog
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Speak(); // Uses inherited method without overriding
        myDog.Bark();  // Dog-specific behavior
    }
}
