using System;

public class Solution {
    // Method to find the most frequent character
    public static char CheckFrequentCharacter(string givenString) {
        int[] characterCount = new int[256];  
        char mostFrequentChar = givenString[0];
        int maxCount = 0;

        // Count occurrences of each character
        foreach (char ch in givenString) {
            characterCount[ch]++;
            if (characterCount[ch] > maxCount) {
                maxCount = characterCount[ch];
                mostFrequentChar = ch;
            }
        }
        return mostFrequentChar;
    }
    
    public static void Main() {
        // Prompt user for string input
        Console.Write("Enter a string: ");
        string givenString = Console.ReadLine();

        char result = CheckFrequentCharacter(givenString);

        // Print result 
        Console.WriteLine("Most Frequent Character in the string is: '{0}'", result);
    }
}
