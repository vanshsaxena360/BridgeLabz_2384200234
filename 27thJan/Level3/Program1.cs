using System;

class Program
{
    // Method to generate an array of random heights for 11 players
    public static int[] GeneratePlayerHeights(int size)
    {
        Random rand = new Random();
        int[] heights = new int[size];

        for (int i = 0; i < size; i++)
        {
            // Generate a random height between 150 and 250 cm
            heights[i] = rand.Next(150, 251);
        }

        return heights;
    }

    // Method to find the sum of all elements in the array
    public static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Method to find the mean height of players
    public static double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    // Method to find the shortest height among players
    public static int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    // Method to find the tallest height among players
    public static int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }

    static void Main(string[] args)
    {
        // Generate an array of 11 random player heights
        int[] playerHeights = GeneratePlayerHeights(11);

        // Calculate sum, mean, shortest, and tallest heights
        int sum = FindSum(playerHeights);
        double mean = FindMean(playerHeights);
        int shortest = FindShortest(playerHeights);
        int tallest = FindTallest(playerHeights);

        // Display the heights of players
        Console.WriteLine("Player Heights (in cm):");
        foreach (int height in playerHeights)
        {
            Console.WriteLine(height);
        }

        // Display the results
        Console.WriteLine("Sum of Heights: " + sum);
        Console.WriteLine("Mean Height: " + mean.ToString("0.00"));
        Console.WriteLine("Shortest Height: " + shortest);
        Console.WriteLine("Tallest Height: " + tallest);
    }
}
