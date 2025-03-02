using System;

class Animal
{
    public virtual void MakeSound()  // Marked as virtual
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()  // Correctly overriding
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        myDog.MakeSound();  // Calls the overridden method in Dog
    }
}
