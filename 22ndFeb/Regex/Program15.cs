using System;
using System.Text.RegularExpressions;

class Program
{
    static bool ValidateSSN(string ssn)
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        return Regex.IsMatch(ssn, pattern);
    }

    static void Main()
    {
        string[] testSSNs = { "123-45-6789", "123456789", "987-65-4321", "12-345-6789" };

        foreach (var ssn in testSSNs)
        {
            if (ValidateSSN(ssn))
                Console.WriteLine($"✅ \"{ssn}\" is valid");
            else
                Console.WriteLine($"❌ \"{ssn}\" is invalid");
        }
    }
}
