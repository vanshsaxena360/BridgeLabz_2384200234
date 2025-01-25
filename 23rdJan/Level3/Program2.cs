using System;

class Program
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.Write("Enter an integer to count its digits: ");
        int number = int.Parse(Console.ReadLine());

        // Handle negative numbers
        if (number < 0)
        {
            number = -number; // Convert to positive to count digits
        }

        // Initialize variables
        int count = 0;

        // Special case for zero
        if (number == 0)
        {
            count = 1;
        }
        else
        {
            // Process: Count digits using a loop
            while (number != 0)
            {
                number /= 10; // Remove the last digit
                count++;      // Increment the count
            }
        }

        // Output: Display the number of digits
        Console.WriteLine("The number has "+count+" digits.");
    }
}
