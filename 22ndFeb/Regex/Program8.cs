using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "This   is   an   example    with   multiple    spaces.";
        
        // Regular expression to replace multiple spaces with a single space
        string output = Regex.Replace(input, @"\s+", " ");
        
        Console.WriteLine("Modified String: " + output);
    }
}
