using System;

class Movement
{
    public void Move()
    {
        Console.WriteLine("Moving.");
    }
}

class Animal
{
    private Movement movement = new Movement();

    public void PerformMove()
    {
        movement.Move();
    }

    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.PerformMove();  // Uses composition instead of inheritance
        myDog.Speak();
    }
}
