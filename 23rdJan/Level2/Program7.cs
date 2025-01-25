using System;

class Program
{
    static void Main()
    {
        // Input: Get the base number
        Console.Write("Enter the base number: ");
        int number = int.Parse(Console.ReadLine());

        // Input: Get the power (exponent)
        Console.Write("Enter the power (exponent): ");
        int power = int.Parse(Console.ReadLine());

        // Initialize the result variable
        int result = 1;

        // Calculate the power using a for loop
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply result with the base number in each iteration
        }

        // Output: Display the result
        Console.WriteLine(number+" raised to the power "+power+" is: "+result);
    }
}
