using System;

class Vehicle  
{
    public void StartEngine()  
    {
        Console.WriteLine("Engine started.");
    }
}

class Car : Vehicle  
{
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
        myCar.StartEngine();  
        myCar.Drive();  
    }
}
