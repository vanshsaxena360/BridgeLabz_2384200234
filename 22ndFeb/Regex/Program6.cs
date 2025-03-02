using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
        
        // Regular expression to match dd/mm/yyyy format
        string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/[0-9]{4}\b";
        
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Dates:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
