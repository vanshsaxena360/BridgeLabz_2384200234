using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the total variable to store the sum
        double total = 0.0;

        // Variable to store the user's input
        double userInput = -1; // Initialize with a value other than 0 to enter the loop

        // Loop while the user input is not 0
        while (userInput != 0)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number (0 to stop): ");
            userInput = double.Parse(Console.ReadLine());

            // Add the entered number to the total if it's not 0
            if (userInput != 0)
            {
                total += userInput;
            }
        }

        // Display the total value
        Console.WriteLine("The total sum of the entered numbers is: "+total);
    }
}
