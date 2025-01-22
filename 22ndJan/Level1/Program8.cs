using System;

class DistanceConverter
{
    static void Main()
    {
        // Prompt the user to enter the distance in kilometers.
        Console.Write("Enter the distance in kilometers: ");

        // Read user input and convert it to a double.
        double km = Convert.ToDouble(Console.ReadLine());

        // Define the conversion factor for kilometers to miles.
        const double KM_TO_MILES = 1.6;

        // Calculate the distance in miles.
        double miles = km / KM_TO_MILES;

        // Display the result.
        Console.WriteLine("The total miles is "+miles+" mile for the given "+km+" km.");
    }
}
