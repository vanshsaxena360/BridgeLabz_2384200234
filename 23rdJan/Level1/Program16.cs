using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a natural number (positive integer)
        if (number < 1)
        {
            Console.WriteLine("Please enter a valid natural number greater than 0.");
        }
        else
        {
            // Iterate from 1 to the entered number
            for (int i = 1; i <= number; i++)
            {
                // Check if the number is even or odd
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" is an even number.");
                }
                else
                {
                    Console.WriteLine(i+" is an odd number.");
                }
            }
        }
    }
}
