using System;

public class CalendarDisplay
{
    // method to get the name of the month
    public static string GetMonthName(int month)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June", 
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // method to check if the year is a leap year
    public static bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }

    // method to get the number of days in the month
    public static int GetNumberOfDays(int month, int year)
    {
        int[] daysInMonth = { 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 
                              31, 31, 30, 31, 30, 31 };
        return daysInMonth[month - 1];
    }

    // method to find the first day of the month using Gregorian algorithm
    public static int GetFirstDayOfMonth(int month, int year)
    {
        if (month < 3)
        {
            month += 12;
            year--;
        }
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;
        return d0;
    }

    // method to display the calendar
    public static void DisplayCalendar(int month, int year)
    {
        Console.WriteLine("\n     " + GetMonthName(month) + " " + year);
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        // get the first day of the month and the number of days in the month
        int firstDay = GetFirstDayOfMonth(month, year);
        int numberOfDays = GetNumberOfDays(month, year);

        // print spaces for the first week
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("   ");
        }

        // print the days of the month
        for (int day = 1; day <= numberOfDays; day++)
        {
            Console.Write("{0,3}", day);

            // move to the next line after Saturday (Saturday = 6)
            if ((firstDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        // Take input from user for month and year
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        // Display the calendar for the given month and year
        DisplayCalendar(month, year);
    }
}
