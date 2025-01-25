using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the month
        Console.Write("Enter the no. of month: ");
        int month = int.Parse(Console.ReadLine());

        // Prompt the user to enter the day
        Console.Write("Enter the day: ");
        int day = int.Parse(Console.ReadLine());

        // Check if the date falls in the spring season
        if ((month == 3 && day >= 20 && day <= 31) || // March 20 to March 31
            (month == 4 && day >= 1 && day <= 30) ||  // April 1 to April 30
            (month == 5 && day >= 1 && day <= 31) ||  // May 1 to May 31
            (month == 6 && day >= 1 && day <= 20))    // June 1 to June 20
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}
