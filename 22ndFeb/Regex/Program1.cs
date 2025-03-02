using System;
using System.Text.RegularExpressions;

class UsernameValidator
{
    public static bool IsValidUsername(string username)
    {
        string pattern = "^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        return Regex.IsMatch(username, pattern);
    }

    static void Main()
    {
        string[] testUsernames = { "user_123", "123user", "us", "validUser_1", "A_valid123" };
        
        foreach (var username in testUsernames)
        {
            Console.WriteLine($"{username} -> {(IsValidUsername(username) ? "Valid" : "Invalid")}");
        }
    }
}
