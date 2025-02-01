using System;

public class PalindromeChecker
{
    // Method to check if a string is a palindrome
    public static bool IsPalindrome(string input){
        int left = 0;
        int right = input.Length - 1;

        while (left < right){
            if (input[left] != input[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    // Main method to get input and display result
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        // Convert to lowercase to handle case insensitivity
        string processedInput = userInput.ToLower();

        if (IsPalindrome(processedInput)){
            Console.WriteLine(userInput+" is a palindrome.");
        }
        else{
		Console.WriteLine(userInput+" is NOT a palindrome.");
        }
    }
}
