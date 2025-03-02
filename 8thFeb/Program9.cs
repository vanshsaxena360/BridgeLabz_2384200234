using System;

abstract class Animal
{
    public void Eat()  // Shared behavior for all animals
    {
        Console.WriteLine("Animal is eating.");
    }

    public abstract void MakeSound();  // Abstract method (must be implemented by subclasses)
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        myDog.Eat();  // inherited from Animal
        myDog.MakeSound();  // Implemented in Dog

        Animal myCat = new Cat();
        myCat.Eat();  // Inherited from Animal
        myCat.MakeSound();  // Implemented in Cat
    }
}
