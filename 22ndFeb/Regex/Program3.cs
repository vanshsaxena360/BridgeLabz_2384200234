using System;
using System.Text.RegularExpressions;

public class Validator
{
    // Method to validate username
    public static bool IsValidUsername(string username)
    {
        return Regex.IsMatch(username, "^[a-zA-Z][a-zA-Z0-9_]{4,14}$");
    }

    // Method to validate license plate number
    public static bool IsValidLicensePlate(string plate)
    {
        return Regex.IsMatch(plate, "^[A-Z]{2}\d{4}$");
    }
    
    // Method to validate hex color code
    public static bool IsValidHexColor(string color)
    {
        return Regex.IsMatch(color, "^#[0-9A-Fa-f]{6}$");
    }

    public static void Main()
    {
        // Test cases for username validation
        Console.WriteLine(IsValidUsername("user_123")); // True
        Console.WriteLine(IsValidUsername("123user")); // False
        Console.WriteLine(IsValidUsername("us")); // False
        
        // Test cases for license plate validation
        Console.WriteLine(IsValidLicensePlate("AB1234")); // True
        Console.WriteLine(IsValidLicensePlate("A12345")); // False
        
        // Test cases for hex color validation
        Console.WriteLine(IsValidHexColor("#FFA500")); // True
        Console.WriteLine(IsValidHexColor("#ff4500")); // True
        Console.WriteLine(IsValidHexColor("#123")); // False
    }
}
