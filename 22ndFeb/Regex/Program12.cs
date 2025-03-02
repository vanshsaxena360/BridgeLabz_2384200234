using System;
using System.Text.RegularExpressions;

class Program
{
    static void ExtractProgrammingLanguages(string text)
    {
        string pattern = @"\b(JavaScript|Java|Python|C\+\+|C#|Go|Ruby|Swift|PHP|Kotlin|Rust|TypeScript|Perl|Scala|Haskell)\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        ExtractProgrammingLanguages(text);
    }
}
