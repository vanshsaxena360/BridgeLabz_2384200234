using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        
        // Regular expression to match capitalized words
        string pattern = "\\b[A-Z][a-z]*\\b";
        
        MatchCollection matches = Regex.Matches(text, pattern);
        
        Console.WriteLine("Capitalized Words:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
