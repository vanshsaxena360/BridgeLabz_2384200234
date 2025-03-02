using System;

class Program
{
    static void Main()
    {
        try
        {
            // Taking user input for division
            Console.Write("Enter the numerator: ");
            int numerator = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the denominator: ");
            int denominator = int.Parse(Console.ReadLine());
            
            // Performing division
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            // Handling division by zero error
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            // Handling non-numeric input error
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (Exception ex)
        {
            // Handling any unexpected exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            // Ensuring execution of final message
            Console.WriteLine("Operation completed.");
        }
    }
}