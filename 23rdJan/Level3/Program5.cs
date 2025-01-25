using System;

class DayOfWeekCalculator
{
    static void Main()
    {
        // Prompt the user for input
        Console.Write("Enter month (1 for January, 2 for February, etc.): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Enter day: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());

        // Adjust the year and month based on the formulas
        int y0 = y - (14 - m) / 12; // Adjusted year
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400; // Intermediate calculation
        int m0 = m + 12 * ((14 - m) / 12) - 2; // Adjusted month
        int d0 = (d + x + 31 * m0 / 12) % 7; // Day of the week (0 = Sunday)

        // Output the result
        string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        Console.WriteLine("The day of the week is "+daysOfWeek[d0]+" ("+d0+").");
    }
}
