using System;

class RoundsCalculator
{
    static void Main()
    {
        // Declare variables to store the sides of the triangle (in meters)
        double side1, side2, side3;

        // Prompt the user to enter the three sides of the triangle
        Console.Write("Enter the first side of the triangle: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangle: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangle: ");
        side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Convert the distance the athlete wants to run to meters (5 km = 5000 meters)
        double totalDistance = 5000;

        // Calculate the number of rounds to complete the total distance
        double rounds = totalDistance / perimeter;

        // Output the result
        Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5 km.");
    }
}
