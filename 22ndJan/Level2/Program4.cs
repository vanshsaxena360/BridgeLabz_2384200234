using System;

class TemperatureConversion
{
    static void Main()
    {
        // Declare the celsius variable to store user input
        double celsius;

        // Prompt the user to enter the temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        
        // Take the input as a string and convert it to a double
        celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the formula (°C × 9/5) + 32 = °F
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Output the result in the specified format
        Console.WriteLine(celsius+" Celsius is "+fahrenheitResult+" Fahrenheit");
    }
}
