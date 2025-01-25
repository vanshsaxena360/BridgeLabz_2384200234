using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()); // Read the input and convert it to an integer

        // Initialize variables
        int sum = 0; // To store the sum of digits
        int temp = number; // Temporary variable to process the digits of the number

        // Loop to calculate the sum of the digits
        while (temp > 0)
        {
            int lastDigit = temp % 10; // Get the last digit of the number
            sum += lastDigit;         // Add the last digit to the sum
            temp /= 10;               // Remove the last digit from the number
        }

        // Check if the number is divisible by the sum of its digits
        if (number % sum == 0)
        {
            Console.WriteLine(number+" is a Harshad Number.");
        }
        else
        {
            Console.WriteLine(number+" is Not a Harshad Number.");
        }
    }
}
