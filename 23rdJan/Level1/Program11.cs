using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the total variable to store the sum
        double total = 0.0;

        // Infinite while loop
        while (true)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number (0 or negative to stop): ");
            double userInput = double.Parse(Console.ReadLine());

            // Check if the user entered 0 or a negative number
            if (userInput <= 0)
            {
                // Break the loop
                break;
            }

            // Add the entered number to the total
            total += userInput;
        }

        // Display the total value
        Console.WriteLine("The total sum of the entered numbers is: "+total);
    }
}
