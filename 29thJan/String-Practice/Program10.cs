using System;

public class Solution {
    // Method to Remove specific character
    public static string RemoveSpecificCharacter (string givenString , char ch) { 
        string modifiedString = "";

        // skip specific character
        foreach (char stringChar in givenString) {
            if (stringChar != ch) {
                modifiedString += stringChar;
            }
        }
        return modifiedString;
    }
    
    public static void Main() {
        // Prompt user for string input
        Console.Write("Enter a string: ");
        string givenString = Console.ReadLine();
		
        Console.Write("Enter Character to remove: ");
        char ch = Console.ReadKey().KeyChar;

        // Print result 
        Console.WriteLine("\nModified string is: {0}", RemoveSpecificCharacter(givenString , ch));
    }
}