using System;

public class ReverseNumber
{
    public static void Main(string[] args)
    {
        // Take user input for the number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Find the count of digits in the number
        int temp = number;
        int digitCount = 0;
        while (temp != 0)
        {
            temp /= 10;
            digitCount++;
        }

        // Create an array to store the digits
        int[] digits = new int[digitCount];

        // Extract the digits of the number and store them in the array
        int index = 0;
        while (number != 0)
        {
            digits[index] = number % 10; // Get the last digit
            number /= 10; // Remove the last digit
            index++;
        }

        // Display the array in reverse order
        Console.WriteLine("The reversed number is:");
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(digits[i]); // Print digits in reverse order
        }
        Console.WriteLine(); // New line for better output formatting
    }
}
