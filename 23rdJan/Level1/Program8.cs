using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the starting value for the countdown
        Console.Write("Enter the countdown starting value: ");
        int counter = int.Parse(Console.ReadLine());

        // Countdown using a while loop
        while (counter >= 1)
        {
            // Print the current value of the counter
            Console.WriteLine(counter);

            // Decrement the counter
            counter--;
        }

        // Print the final launch message
        Console.WriteLine("launch the Rocket!");
    }
}
