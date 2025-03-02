using System;

// Abstract Class (Preferred Over Concrete Base Class)
abstract class Animal
{
    public abstract string Speak();
}

// Subclasses Inheriting from Abstract Class
class Dog : Animal
{
    public override string Speak()
    {
        return "Dog barks";
    }
}

class Cat : Animal
{
    public override string Speak()
    {
        return "Cat meows";
    }
}

// Main Program (Manual Testing)
class Program
{
    static void Main()
    {
        Animal myDog = new Dog();
        Console.WriteLine(myDog.Speak()); // Output

        Animal myCat = new Cat();
        Console.WriteLine(myCat.Speak()); // Output
    }
}
