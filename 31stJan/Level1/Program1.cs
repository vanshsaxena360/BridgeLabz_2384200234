using System;

public class TimeZoneConverter
{
    public static void Main()
    {
        // Get current UTC time
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;
        Console.WriteLine("Current UTC Time: " + utcTime.ToString("yyyy-MM-dd HH:mm:ss"));

        // Convert to GMT (Greenwich Mean Time)
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcTime, "GMT Standard Time");
        Console.WriteLine("GMT Time: " + gmtTime.ToString("yyyy-MM-dd HH:mm:ss"));

        // Convert to IST (Indian Standard Time)
        DateTimeOffset istTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcTime, "India Standard Time");
        Console.WriteLine("IST Time: " + istTime.ToString("yyyy-MM-dd HH:mm:ss"));

        // Convert to PST (Pacific Standard Time)
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcTime, "Pacific Standard Time");
        Console.WriteLine("PST Time: " + pstTime.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}
