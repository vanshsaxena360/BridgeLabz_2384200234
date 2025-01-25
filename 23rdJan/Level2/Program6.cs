using System;

class Program
{
    static void Main()
    {
        // Pormpt Input: Get the integer input from the user
        Console.Write("Enter a number to find its greatest factor (excluding itself): ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("The number must be greater than 1 to have a proper factor.");
            return;
        }

        // Initialize the greatest factor variable
        int greatestFactor = 1;

        // Loop to find the greatest factor (excluding the number itself)
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0) // Check if the number is perfectly divisible by i
            {
                greatestFactor = i;
                break; // Exit the loop once the greatest factor is found
            }
        }

        // Output: Display the greatest factor
        Console.WriteLine("The greatest factor of "+number+" (excluding itself) is: "+greatestFactor);
    }
}
