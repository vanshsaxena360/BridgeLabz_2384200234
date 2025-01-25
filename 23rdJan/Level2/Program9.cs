using System;

class Program
{
    static void Main()
    {
        // Input: Get the number from the user
        Console.Write("Enter a number to find its multiples below 100: ");
        int number = int.Parse(Console.ReadLine());

        // Output message
        Console.WriteLine("The multiples of "+number+" below 100 are:");

        // Loop backward from 100 to 1
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0) // Check if 'i' is a multiple of 'number'
            {
                Console.WriteLine(i); // Print the multiple
            }
        }
    }
}
