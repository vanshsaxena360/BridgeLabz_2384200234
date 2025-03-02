using System;

// Define interfaces for multiple behaviors
interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

// Duck implements both interfaces
class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");
    }
}

class Program
{
    static void Main()
    {
        Duck duck = new Duck();
        duck.Fly();   // Duck is flying.
        duck.Swim();  // Duck is swimming.
        
        // Using interface references
        IFlyable flyingDuck = new Duck();
        flyingDuck.Fly();  // Can only call Fly()

        ISwimmable swimmingDuck = new Duck();
        swimmingDuck.Swim();  // Can only call Swim()
    }
}
