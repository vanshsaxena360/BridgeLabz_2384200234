using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()); // Read the input and convert it to an integer

        // Initialize sum to store the sum of divisors
        int sum = 0;

        // Loop to find all divisors of the number
        for (int i = 1; i < number; i++)
        {
            // Check if i is a divisor of the number
            if (number % i == 0)
            {
                sum += i; 
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            Console.WriteLine(number+" is an Abundant Number.");
        }
        else
        {
            Console.WriteLine(number+" is Not an Abundant Number.");
        }
    }
}
