using System;

// Custom exception class for invalid age
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class Program
{
    // Method to validate age, throws an exception if age is below 18
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or above");
        }
    }

    static void Main()
    {
        try
        {
            // Taking user input for age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            
            // Validating the entered age
            ValidateAge(age);
            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException ex)
        {
            // Handling custom exception when age is below 18
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            // Handling exception if user enters a non-numeric value
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
        catch (Exception ex)
        {
            // Handling any other unexpected exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}