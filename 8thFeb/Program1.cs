using System;

class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }
}

class Car
{
    private Engine _engine; // Composition: Car "has-a" Engine

    public Car()
    {
        _engine = new Engine(); // Creating an Engine instance inside Car
    }

    public void StartCar()
    {
        _engine.Start(); // Using Engine's method
    }

    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.StartCar();
        myCar.Drive();
    }
}
