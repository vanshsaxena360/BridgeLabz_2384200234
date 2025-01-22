using System;

class JourneyDetails
{
    static void Main()
    {
        // Declare variables to store user inputs for name and cities
        string name, fromCity, viaCity, toCity;

        // Declare variables to store the distances in miles
        double fromToVia, viaToFinalCity;

        // Declare variable to store the time taken for the journey
        double timeTaken;

        // Take user inputs for name and cities
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter the starting city (fromCity): ");
        fromCity = Console.ReadLine();

        Console.Write("Enter the via city (viaCity): ");
        viaCity = Console.ReadLine();

        Console.Write("Enter the final city (toCity): ");
        toCity = Console.ReadLine();

        // Take user inputs for distances in miles
        Console.Write("Enter the distance from "+fromCity+" to "+viaCity+" (miles): ");
        fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from "+viaCity+" to "+toCity+" (miles): ");
        viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Take user input for the time taken for the journey
        Console.Write("Enter the time taken for the journey (in hours): ");
        timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculate the total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Output the results
        Console.WriteLine("\nThe results of the trip are:\n" +
                          "Traveler: "+name+
                          "\nJourney: "+fromCity+" -> "+viaCity+" -> "+toCity +
                          "\nTotal distance traveled: "+totalDistance+" miles\n" +
                          "Average speed: "+averageSpeed+" miles per hour");
    }
}
