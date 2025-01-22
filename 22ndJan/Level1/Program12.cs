using System;

class TriangleAreaCalculator
{
    static void Main()
    {
        // Prompt the user to enter the base of the triangle in inches.
        Console.Write("Enter the base of the triangle in inches: ");
        // Read the user input and convert it to a floating-point number.
        double baseInInches = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the height of the triangle in inches.
        Console.Write("Enter the height of the triangle in inches: ");
        // Read the user input and convert it to a floating-point number.
        double heightInInches = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle in square inches using the formula: ½ * base * height.
        double areaInSquareInches = 0.5 * baseInInches * heightInInches;

        // Define the conversion factor for square inches to square centimeters.
        const double INCH_TO_CM = 2.54; // 1 inch = 2.54 cm.
        double areaInSquareCentimeters = areaInSquareInches * (INCH_TO_CM * INCH_TO_CM);

        // Display the results in both square inches and square centimeters.
        Console.WriteLine("The area of the triangle is "+areaInSquareInches+" square inches and "+areaInSquareCentimeters+" square centimeters.");
    }
}
