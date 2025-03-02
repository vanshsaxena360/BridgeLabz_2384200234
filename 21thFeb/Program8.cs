using System;

class Program
{
    // Method1 throws an ArithmeticException
    static void Method1()
    {
        throw new ArithmeticException("Attempted to divide by zero.");
    }

    // Method2 calls Method1
    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            // Calling Method2, which propagates the exception from Method1
            Method2();
        }
        catch (ArithmeticException)
        {
            // Handling the exception in Main
            Console.WriteLine("Handled exception in Main");
        }
        catch (Exception ex)
        {
            // Handling any other unexpected exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
