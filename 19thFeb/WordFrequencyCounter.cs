using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    static void Main()
    {
        string filePath = "sample.txt"; // Change this to your file path

        // Read the text file
        string text = File.ReadAllText(filePath).ToLower();

        // Use regex to extract words (ignoring punctuation)
        string[] words = Regex.Split(text, @"\W+").Where(w => !string.IsNullOrEmpty(w)).ToArray();

        // Dictionary to store word frequency
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        // Display word frequency
        Console.WriteLine("Word Frequency Count:");
        foreach (var pair in wordCount)
        {
            Console.WriteLine(pair.Key+" : "+pair.Value);
        }
    }
}
