using System;

interface IVehicle
{
    void Move();  // Common behavior for all vehicles
}

interface IFuelPowered
{
    void Refuel();  // Only for fuel-powered vehicles
}

class GasCar : IVehicle, IFuelPowered
{
    public void Move()
    {
        Console.WriteLine("The gas car is moving.");
    }

    public void Refuel()
    {
        Console.WriteLine("Refueling the gas car.");
    }
}

class ElectricCar : IVehicle
{
    public void Move()
    {
        Console.WriteLine("The electric car is moving.");
    }
    
    public void Charge()
    {
        Console.WriteLine("Charging the electric car.");
    }
}

class Program
{
    static void Main()
    {
        IVehicle myCar = new ElectricCar();
        myCar.Move();

        IFuelPowered myFuelCar = new GasCar();
        myFuelCar.Refuel(); // Only fuel-powered cars refuel
    }
}
