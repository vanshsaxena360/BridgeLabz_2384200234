using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive, negative, or zero
        if (number > 0)
        {
            // Output if the number is positive
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            // Output if the number is negative
            Console.WriteLine("The number is negative.");
        }
        else
        {
            // Output if the number is zero
            Console.WriteLine("The number is zero.");
        }
    }
}
