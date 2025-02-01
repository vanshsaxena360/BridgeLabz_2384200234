using System;

public class DateArithmetic
{
    public static void Main()
    {
        // Step 1: Get user input for the date
        Console.Write("Enter a date (YYYY-MM-DD): ");
        DateTime inputDate=DateTime.Parse(Console.ReadLine());

        Console.WriteLine("\nOriginal Date: " + inputDate.ToString("yyyy-MM-dd"));

        // Step 2: Add 7 days, 1 month, and 2 years
        DateTime newDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        Console.WriteLine("After adding 7 days, 1 month, and 2 years: " + newDate.ToString("yyyy-MM-dd"));

        // Step 3: Subtract 3 weeks (21 days)
        DateTime finalDate = newDate.AddDays(-21);
        Console.WriteLine("After subtracting 3 weeks: " + finalDate.ToString("yyyy-MM-dd"));
    }
}
