using System;

public class Circle
{
    // Attribute for radius of the circle
    public double Radius { get; set; }

    // Method to calculate the area of the circle
    public double CalculateArea(){
        return Math.PI * Math.Pow(Radius, 2); // Formula: Area = π * r^2
    }

    // Method to calculate the circumference of the circle
    public double CalculateCircumference(){
        return 2 * Math.PI * Radius; // Formula: Circumference = 2 * π * r
    }

    // Method to display the area and circumference
    public void DisplayDetails()
    {
        Console.WriteLine("Circle with radius: " + Radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of Circle class
        Circle circle = new Circle();

        // Taking input for the radius
        Console.WriteLine("Enter the radius of the circle: ");
        circle.Radius = double.Parse(Console.ReadLine());

        // Calling method to display area and circumference
        circle.DisplayDetails();
    }
}
