using System;

class Program
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.Write("Enter a number to check if it's an Armstrong number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize variables
        int originalNumber = number; // Store the original number
        int sum = 0; // To store the sum of cubes of digits

        // Process: Calculate the sum of cubes of digits
        while (originalNumber != 0)
        {
            int remainder = originalNumber % 10; // Get the last digit
            sum += remainder * remainder * remainder; // Add the cube of the digit to the sum
            originalNumber /= 10; // Remove the last digit
        }

        // Output: Check if the sum is equal to the original number
        if (sum == number)
        {
            Console.WriteLine(number+" is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(number+" is not an Armstrong number.");
        }
    }
}
