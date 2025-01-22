using System;

class DistanceConverter
{
    static void Main()
    {
        // Prompt the user to enter the distance in feet.
        Console.Write("Enter the distance in feet: ");
        // Read the user input and convert it to a floating-point number.
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Conversion constants.
        const int FEET_IN_YARD = 3; // 1 yard = 3 feet
        const int YARDS_IN_MILE = 1760; // 1 mile = 1760 yards

        // Convert the distance to yards and miles.
        double distanceInYards = distanceInFeet / FEET_IN_YARD;
        double distanceInMiles = distanceInYards / YARDS_IN_MILE;

        // Display the results in a user-friendly format.
        Console.WriteLine("The distance of "+distanceInFeet+" feet is equivalent to "+distanceInYards+" yards and "+distanceInMiles+" miles.");
    }
}
