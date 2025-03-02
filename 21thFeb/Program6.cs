using System;
using System.IO;

class Program
{
    // Method to calculate interest, throws exception if input is invalid
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Invalid input: Amount and rate must be positive");
        }
        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            // Taking user input
            Console.Write("Enter the principal amount: ");
            double amount = double.Parse(Console.ReadLine());
            
            Console.Write("Enter the interest rate: ");
            double rate = double.Parse(Console.ReadLine());
            
            Console.Write("Enter the number of years: ");
            int years = int.Parse(Console.ReadLine());
            
            // Calculating and displaying interest
            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("Calculated Interest: " + interest);
        }
        catch (ArgumentException ex)
        {
            // Handling invalid input exceptions
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            // Handling non-numeric input
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (Exception ex)
        {
            // Handling unexpected exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
