using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a natural number
        if (number >= 1) // Natural numbers are positive integers starting from 1
        {
            // Calculate the sum of n natural numbers
            int sum = number * (number + 1) / 2;

            // Output the result
            Console.WriteLine("The sum of "+number+" natural numbers is "+sum);
        }
        else
        {
            // Output if the number is not a natural number
            Console.WriteLine("The number "+number+" is not a natural number");
        }
    }
}
