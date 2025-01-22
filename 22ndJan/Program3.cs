using System;

class Program
{
    static void Main()
    {
        // Define a constant to store the conversion factor from kilometers to miles.
        // 1 kilometer is equal to 1.6 miles, as per the problem's hint.
        const double kilometersToMilesConversionFactor = 1.6;

        // Declare and initialize a variable to store the distance in kilometers.
        // The distance is given as 10.8 kilometers.
        double distanceInKilometers = 10.8;

        // Calculate the equivalent distance in miles by multiplying the distance in kilometers
        // by the conversion factor.
        double distanceInMiles = distanceInKilometers * kilometersToMilesConversionFactor;

        // Output the result to the console
        Console.WriteLine("The distance "+distanceInKilometers+" km in miles is "+distanceInMiles);
    }
}
