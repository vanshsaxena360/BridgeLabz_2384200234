using System;

// Behavior Class (Delegation Instead of Inheritance)
class SoundBehavior
{
    private string sound;

    public SoundBehavior(string sound)
    {
        this.sound = sound;
    }

    public string MakeSound()
    {
        return sound;
    }
}

// Main Class Using Delegation Instead of Inheriting
class Animal
{
    private string name;
    private SoundBehavior soundBehavior; // Delegation

    public Animal(string name, SoundBehavior soundBehavior)
    {
        this.name = name;
        this.soundBehavior = soundBehavior;
    }

    public void Speak()
    {
        Console.WriteLine(name+" says: "+soundBehavior.MakeSound());
    }
}

// Main Program (Manual Testing)
class Program
{
    static void Main()
    {
        // Creating animals with delegated behavior
        Animal dog = new Animal("Dog", new SoundBehavior("Woof! Woof!"));
        Animal cat = new Animal("Cat", new SoundBehavior("Meow! Meow!"));

        // Testing behavior
        dog.Speak(); // Output: Dog says: Woof! Woof!
        cat.Speak(); // Output: Cat says: Meow! Meow!
    }
}
