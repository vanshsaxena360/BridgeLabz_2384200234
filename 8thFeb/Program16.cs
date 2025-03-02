using System;

// Superclass
class Animal
{
    public virtual string Speak()
    {
        return "Animal makes a sound.";
    }
}

// Subclass
class Dog : Animal
{
    public override string Speak()
    {
        return "Dog barks";
    }
}

// Main Program (For Manual Testing)
class Program
{
    static void Main()
    {
        // Testing Superclass
        Animal myAnimal = new Animal();
        Console.WriteLine("Animal Test: " + (myAnimal.Speak() == "Animal makes a sound." ? "Passed" : "Failed"));

        // Testing Subclass
        Dog myDog = new Dog();
        Console.WriteLine("Dog Test: " + (myDog.Speak() == "Dog barks" ? "Passed" : "Failed"));
    }
}
