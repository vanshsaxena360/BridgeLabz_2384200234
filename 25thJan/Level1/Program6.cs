using System;

public class MeanHeight
{
    public static void Main(string[] args)
    {
        double[] heights = new double[11]; // Array to store heights of 11 players

        // Get input heights from the user
        Console.WriteLine("Enter heights of 11 players:");
        for (int i = 0; i < 11; i++)
        {
            Console.Write("Player {0}: ", i + 1);
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate the sum of heights
        double sum = 0;
        for (int i = 0; i < 11; i++)
        {
            sum += heights[i];
        }

        // Calculate the mean height
        double meanHeight = sum / 11;

        // Display the mean height
        Console.WriteLine("Mean height of the football team: " + meanHeight);
    }
}