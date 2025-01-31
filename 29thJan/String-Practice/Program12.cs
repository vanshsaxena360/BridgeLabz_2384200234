using System;

public class Solution {
    // Method to replace a word in a sentence
    public static string ReplaceWord(string sentence, string target, string replacement) {
        int strLen = sentence.Length, targetLen = target.Length;
        string result = "";
        
        for (int i = 0; i < strLen; i++) {
            int j;
            
            // Checking whether substring matches target
            for (j = 0; j < targetLen; j++) {
                if (i + j >= strLen || sentence[i + j] != target[j]) {
                    break;
                }
            }

            // If a full match found
            if (j == targetLen) {
                result += replacement;
                i += targetLen - 1; 
            } else {
                result += sentence[i];  
            }
        }
        
        return result;
    }

    public static void Main() {
        // Prompt user for sentence, target and replacement input
        Console.WriteLine("Enter Sentence: ");
        string sentence = Console.ReadLine();        

        Console.WriteLine("Enter the word to replace: ");
        string target = Console.ReadLine();

        Console.WriteLine("Enter the replacement word: ");
        string replacement = Console.ReadLine();
        
        // Print result 
        Console.WriteLine("Modified string is: {0}", ReplaceWord(sentence, target, replacement));
    }
}