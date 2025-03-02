using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info.";
        
        // Regular expression to match URLs
        string pattern = @"https?://[a-zA-Z0-9\-._~:/?#\[\]@!$&'()*+,;=%]+";
        
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Links:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
