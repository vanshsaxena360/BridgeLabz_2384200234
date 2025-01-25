using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the starting value for the countdown
        Console.Write("Enter the countdown starting value: ");
        int counter = int.Parse(Console.ReadLine());

        // Countdown using a for loop
        for (int i = counter; i >= 1; i--)
        {
            // Print the current value of the counter
            Console.WriteLine(i);
        }

        // Print the final launch message
        Console.WriteLine("launch the Rocket!");
    }
}
