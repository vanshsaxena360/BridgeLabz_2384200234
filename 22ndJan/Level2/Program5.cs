using System;

class TemperatureConversion
{
    static void Main()
    {
        // Declare the fahrenheit variable to store user input
        double fahrenheit;

        // Prompt the user to enter the temperature in Fahrenheit
        Console.Write("Enter the temperature in Fahrenheit: ");
        
        // Take the input as a string and convert it to a double
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert Fahrenheit to Celsius using the formula (°F − 32) × 5/9 = °C
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Output the result
        Console.WriteLine(fahrenheit+" Fahrenheit is "+celsiusResult+" Croelsius");
    }
}
