using System;

public class DigitFrequency
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Create an array to store the frequency of the digit
        int[] frequency = new int[10];

        // Calculate frequency of each digit
        while (number > 0)
        {
            int digit = number % 10; // Extract the last digit
            frequency[digit]++;      // Increment the frequency of the digit
            number /= 10;            // Remove the last digit from the number
        }

        // Display the frequency of each digit
        Console.WriteLine("Frequency of each digit:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit "+i+": "+frequency[i]);
            }
        }
    }
}