using System;

class Program
{
    static void Main()
    {
        // Define a constant for the radius of the Earth in kilometers (6378 km).
        const double radiusInKm = 6378;

        // Define a constant for the conversion factor from cubic kilometers to cubic miles.
        // 1 kilometer is approximately equal to 0.621371 miles.
        // Hence, the conversion factor for volume is (0.621371)^3.
        const double kmToMilesConversionFactor = 0.621371 * 0.621371 * 0.621371;

        // Calculate the volume of the Earth in cubic kilometers using the formula:
        // Volume = (4/3) * pi * r^3
        double volumeInKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusInKm, 3);

        // Convert the volume from cubic kilometers to cubic miles.
        double volumeInMiles3 = volumeInKm3 * kmToMilesConversionFactor;

        // Output the results 
        Console.WriteLine("The volume of Earth in cubic kilometers is "+volumeInKm3+" and in cubic miles is "+volumeInMiles3);
    }
}
