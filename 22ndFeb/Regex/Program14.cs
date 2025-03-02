using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void FindRepeatingWords(string text)
    {
        string pattern = @"\b(\w+)\b(?=.*\b\1\b)";
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        HashSet<string> uniqueWords = new HashSet<string>();

        foreach (Match match in matches)
        {
            uniqueWords.Add(match.Value.ToLower());
        }

        Console.WriteLine(string.Join(", ", uniqueWords));
    }

    static void Main()
    {
        string text = "This is is a repeated repeated word test.";
        FindRepeatingWords(text);
    }
}
