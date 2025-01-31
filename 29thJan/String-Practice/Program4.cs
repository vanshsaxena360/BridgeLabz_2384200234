using System;

public class RemoveDuplicateCharacters {
    public static string RemoveDuplicates(string input) {
        string result = "";
        bool[] seen = new bool[256]; // Boolean array to track seen characters

        for (int i = 0; i < input.Length; i++) {
            char currentChar = input[i];

            if (!seen[currentChar]) { // If character is not already seen
                result += currentChar;
                seen[currentChar] = true; // Mark character as seen
            }
        }
        return result;
    }

    public static void Main() {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        string modifiedString = RemoveDuplicates(userInput);
        Console.WriteLine("String after removing duplicates: " + modifiedString);
    }
}
