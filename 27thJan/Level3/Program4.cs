using System;

public class NumberChecker
{
    // method to count digits in a number
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // method to store digits of a number in an array
    public static int[] GetDigitsArray(int number)
    {
        number = Math.Abs(number); // handle negative numbers
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // method to reverse the digits array
    public static int[] ReverseArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }

    // method to compare two arrays and check if they are equal
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }

    // method to check if a number is a palindrome
    public static bool IsPalindrome(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[] reversed = ReverseArray(digits);
        return AreArraysEqual(digits, reversed);
    }

    // method to check if a number is a duck number
    public static bool IsDuckNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        foreach (int digit in digits)
        {
            if (digit == 0)
            {
                return true;
            }
        }
        return false;
    }

    // main method to test the functionality
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // count digits
        int digitCount = CountDigits(number);
        Console.WriteLine("Number of digits: " + digitCount);

        // store digits in an array
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // reverse digits
        int[] reversed = ReverseArray(digits);
        Console.WriteLine("Reversed digits: " + string.Join(", ", reversed));

        // check if the number is a palindrome
        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine("Is palindrome: " + isPalindrome);

        // check if the number is a duck number
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine("Is duck number: " + isDuck);
    }
}
