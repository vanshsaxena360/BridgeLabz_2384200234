using System;

class Program
{
    // Method to check if the given date is within the Spring season (March 20 to June 20)
    static bool IsSpringSeason(int month, int day)
    {
        // Check if the month and day fall within the Spring season range
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            return true; // It's Spring season
        }
        return false; // Not a Spring season
    }

    static void Main(string[] args)
    {
        // Input: Take month and day from the command line arguments
		Console.Write("Enter the month no.: ");
        int month = int.Parse(Console.ReadLine()); // First command line argument for month
		Console.Write("Enter the day: ");
        int day = int.Parse(Console.ReadLine());   // Second command line argument for day

        // Check if it's Spring season
        bool isSpring = IsSpringSeason(month, day);

        // Output result
        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
