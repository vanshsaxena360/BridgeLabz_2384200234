using System;

class Program
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());

        // Output message
        Console.WriteLine("The factors of "+number+" are:");

        // Loop to find and print factors
        for (int i = 1; i <= number; i++) // Loop from 1 to the number
        {
            if (number % i == 0) // Check if 'i' is a factor of 'number'
            {
                Console.WriteLine(i); // Print the factor
            }
        }
    }
}
