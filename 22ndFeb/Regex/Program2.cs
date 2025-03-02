using System;
using System.Text.RegularExpressions;

class Validator
{
    public static bool IsValidUsername(string username)
    {
        string pattern = "^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        return Regex.IsMatch(username, pattern);
    }

    public static bool IsValidLicensePlate(string plate)
    {
        string pattern = "^[A-Z]{2}\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }

    static void Main()
    {
        string[] testUsernames = { "user_123", "123user", "us", "validUser_1", "A_valid123" };
        string[] testPlates = { "AB1234", "A12345", "XY9876", "ZZ12A4" };
        
        foreach (var username in testUsernames)
        {
            Console.WriteLine($"{username} -> {(IsValidUsername(username) ? "Valid" : "Invalid")}");
        }
        
        foreach (var plate in testPlates)
        {
            Console.WriteLine($"{plate} -> {(IsValidLicensePlate(plate) ? "Valid" : "Invalid")}");
        }
    }
}
