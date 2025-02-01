using System;

public class TemperatureConverter
{
    // Method to convert Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }

    // Method to convert Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }

    // Main method for user interaction
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nTemperature Converter");
            Console.WriteLine("1. Convert Fahrenheit to Celsius");
            Console.WriteLine("2. Convert Celsius to Fahrenheit");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option (1-3): ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 3){
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }

            Console.Write("Enter temperature value: ");
            double temperature = double.Parse(Console.ReadLine());
            

            if (choice == 1){
                double celsius = FahrenheitToCelsius(temperature);
                Console.WriteLine("Result: "+temperature+"°F = "+celsius+"°C");
            }
            else if (choice == 2){
                double fahrenheit = CelsiusToFahrenheit(temperature);
                Console.WriteLine("Result: "+temperature+"°C = "+fahrenheit+"°F");
            }
        }
    }
}
