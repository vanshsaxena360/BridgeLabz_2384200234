using System;

public class DateFormatting
{
    public static void Main()
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Format 1: dd/MM/yyyy
        string format1 = currentDate.ToString("dd/MM/yyyy");

        // Format 2: yyyy-MM-dd
        string format2 = currentDate.ToString("yyyy-MM-dd");

        // Format 3: EEE, MMM dd, yyyy (Works without CultureInfo)
        string format3 = currentDate.ToString("ddd, MMM dd, yyyy");

        // Display the formatted dates
        Console.WriteLine("Current Date in Different Formats:");
        Console.WriteLine("Format 1 (dd/MM/yyyy)     : " + format1);
        Console.WriteLine("Format 2 (yyyy-MM-dd)     : " + format2);
        Console.WriteLine("Format 3 (EEE, MMM dd, yyyy) : " + format3);
    }
}
