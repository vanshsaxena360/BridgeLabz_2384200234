using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the user has entered a positive integer
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            // Initialize the variable for the factorial
            int factorial = 1;

            // Compute the factorial using a for loop
            for (int i = 1; i <= number; i++)
            {
                factorial *= i; // Multiply factorial by current i
            }

            // Print the result
            Console.WriteLine("The factorial of "+number+" is "+factorial);
        }
    }
}
