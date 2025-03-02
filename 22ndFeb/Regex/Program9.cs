using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        
        // List of bad words to censor
        string[] badWords = { "damn", "stupid" };

        // Replace each bad word with asterisks
        foreach (string word in badWords)
        {
            input = Regex.Replace(input, $@"\b{word}\b", "****", RegexOptions.IgnoreCase);
        }

        Console.WriteLine("Censored Sentence: " + input);
    }
}
