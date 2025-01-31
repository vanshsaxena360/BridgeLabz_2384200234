using System;

public class Solution {
    // Method to check if two strings are anagrams
    public static bool CheckAnagrams(string givenString1, string givenString2) {
        int len1 = givenString1.Length , len2 = givenString2.Length;
        if (len1 != len2) return false; 

        int[] charCount = new int[256]; 

        // Count character occurrences in str1
        for (int i = 0 ; i < len1 ; i++) {
            charCount[(int)(givenString1[i])] += 1;
        }
 
        // Subtract character occurrences in str2
        for (int i = 0 ; i < len2 ; i++) {
            charCount[(int)(givenString2[i])] -= 1;
        }

        // If all values in charCount are zero, they are anagrams
        for (int i = 0; i < 256; i++) {
            if (charCount[i] != 0) return false;
        }

        return true;
    }

    public static void Main() {
        // prompt user for 2 string input
        Console.WriteLine("Enter first string: ");
        string givenString1 = Console.ReadLine();        

        Console.WriteLine("Enter second string: ");
        string givenString2 = Console.ReadLine();
        
        // Check for anagram and print result
        if (CheckAnagrams(givenString1 , givenString2)) {
            Console.WriteLine("The two strings are anagrams");
        }
        else {
            Console.WriteLine("The two strings are NOT anagrams");
        }
    }
}