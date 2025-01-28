using System;

class Program
{
    // Method to calculate the wind chill temperature
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        // Wind chill formula
        double windChill = 35.74 + (0.6215 * temperature) + ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));

        return windChill;
    }

    static void Main(string[] args)
    {
        // Input: Take temperature and wind speed from the user
        Console.Write("Enter the temperature in Fahrenheit: ");
        double temperature = double.Parse(Console.ReadLine());

        Console.Write("Enter the wind speed in miles per hour: ");
        double windSpeed = double.Parse(Console.ReadLine());

        // Call the method to calculate wind chill
        double windChill = CalculateWindChill(temperature, windSpeed);

        // Output the result
        Console.WriteLine("The wind chill temperature is: "+windChill.ToString("F2")+"°F");
    }
}
