using System;

public class YoungestAndTallest
{
    public static void Main(string[] args)
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        double[] ages = new double[3];
        double[] heights = new double[3];

        // Get age and height input for all three friends
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter age of " + friends[i] + ":");
            ages[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of " + friends[i] + " (in cm):");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find the youngest friend
        double minAge = ages[0];
        int youngestIndex = 0;

        // Find the tallest friend
        double maxHeight = heights[0];
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                youngestIndex = i;
            }

            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                tallestIndex = i;
            }
        }

        // Display the youngest and tallest friends
        Console.WriteLine("\nThe youngest friend is: " + friends[youngestIndex] + " with age " + minAge);
        Console.WriteLine("The tallest friend is: " + friends[tallestIndex] + " with height " + maxHeight + " cm");
    }
}
