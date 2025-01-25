using System;

class Program
{
    static void Main()
    {
        // Prompt Input: Collect ages and heights of Amar, Akbar, and Anthony
        Console.WriteLine("Enter the age and height of Amar:");
        Console.Write("Age: ");
        int ageAmar = int.Parse(Console.ReadLine());
        Console.Write("Height (in cm): ");
        int heightAmar = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter the age and height of Akbar:");
        Console.Write("Age: ");
        int ageAkbar = int.Parse(Console.ReadLine());
        Console.Write("Height (in cm): ");
        int heightAkbar = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter the age and height of Anthony:");
        Console.Write("Age: ");
        int ageAnthony = int.Parse(Console.ReadLine());
        Console.Write("Height (in cm): ");
        int heightAnthony = int.Parse(Console.ReadLine());

        // Determine the youngest friend
        int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        string youngestFriend = "";

        if (youngestAge == ageAmar) youngestFriend = "Amar";
        else if (youngestAge == ageAkbar) youngestFriend = "Akbar";
        else youngestFriend = "Anthony";

        // Determine the tallest friend
        int tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
        string tallestFriend = "";

        if (tallestHeight == heightAmar) tallestFriend = "Amar";
        else if (tallestHeight == heightAkbar) tallestFriend = "Akbar";
        else tallestFriend = "Anthony";

        // Output results
        Console.WriteLine("\nThe youngest friend is "+youngestFriend+" with age "+youngestAge+" years.");
        Console.WriteLine("The tallest friend is "+tallestFriend+" with height "+tallestHeight+" cm.");
    }
}
