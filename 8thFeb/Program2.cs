using System;

class Vehicle  // Base class
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }
}

class Car : Vehicle  // Car "is-a" Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Bicycle  // Bicycle does NOT inherit Vehicle because it has no engine
{
    public void Pedal()
    {
        Console.WriteLine("Pedaling the bicycle.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.StartEngine();  // Car has an engine
        myCar.Drive();

        Bicycle myBike = new Bicycle();
        myBike.Pedal();  // Bicycle has no engine, so no inheritance from Vehicle
    }
}
