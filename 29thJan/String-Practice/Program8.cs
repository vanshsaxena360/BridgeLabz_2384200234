using System;

public class Solution {
    // Method to compare strings
    public static string CompareStrings(string str1, string str2) {
        int len1 = str1.Length, len2 = str2.Length;
        int minLength = Math.Min(len1, len2);
        
        for (int i = 0; i < minLength; i++) {
            if (char.ToLower(str1[i]) < char.ToLower(str2[i])) {
                return str1+" comes before "+str2;  
            }
            if (char.ToLower(str1[i]) > char.ToLower(str2[i])){
                return str2+" comes before "+str1;
            }
        }

        // If all compared characters are equal, compare lengths
        if (len1 < len2) return str1+" comes before "+str2;  
        if (len1 > len2) return str2+" comes before "+str1;  

        return "Both strings are equal.";  
    }

    public static void Main() {
        // Prompt user to enter 2 strings
        Console.Write("Enter the string 1: ");
        string givenString1 = Console.ReadLine();
        
        Console.Write("Enter the string 2: ");
        string givenString2 = Console.ReadLine();

        Console.WriteLine("{0} in lexicographical order" , CompareStrings(givenString1, givenString2));
    }
}