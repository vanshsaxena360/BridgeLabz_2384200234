using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter a number
        Console.Write("Enter a number: ");

        // Read the input from the user and convert it to an integer
        int number = int.Parse(Console.ReadLine());

        // Check if the number is divisible by 5
        if (number % 5 == 0)
        {
            // Output if the number is divisible by 5
            Console.WriteLine("Is the number "+number+" divisible by 5? Yes");
        }
        else
        {
            // Output if the number is not divisible by 5
            Console.WriteLine("Is the number "+number+" divisible by 5? No");
        }
    }
}
