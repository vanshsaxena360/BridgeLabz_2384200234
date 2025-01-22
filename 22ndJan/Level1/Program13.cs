using System;

class SquareSideCalculator
{
    static void Main()
    {
        // Prompt the user to enter the perimeter of the square.
        Console.Write("Enter the perimeter of the square: ");
        // Read the user input and convert it to a floating-point number.
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side of the square using the formula: side = perimeter / 4.
        double side = perimeter / 4;

        // Display the result in a user-friendly format.
        Console.WriteLine("The length of the side is "+side+" whose perimeter is "+perimeter);
    }
}
