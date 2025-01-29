using System;

public class NumberChecker
{
    // Method to count digits in a number
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

    // Method to store digits of a number in an array
    public static int[] GetDigitsArray(int number)
    {
        number = Math.Abs(number); // Handle negative numbers
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to calculate the sum of digits
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to calculate the sum of squares of digits
    public static int SumOfSquares(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    // Method to check if a number is a Harshad number
    public static bool IsHarshadNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int sum = SumOfDigits(digits);
        return number % sum == 0;
    }

    // Method to calculate the frequency of each digit
    public static int[,] DigitFrequency(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[,] frequency = new int[10, 2]; // 10 digits (0-9), 2 columns: digit and count

        // Initialize frequency array
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i; // Digit
            frequency[i, 1] = 0; // Initial frequency
        }

        // Count frequency
        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }

    // Main method to demonstrate the functionality
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Count digits
        int digitCount = CountDigits(number);
        Console.WriteLine("Number of digits: " + digitCount);

        // Store digits in an array
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // Sum of digits
        int sum = SumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sum);

        // Sum of squares of digits
        int sumOfSquares = SumOfSquares(digits);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);

        // Check if the number is a Harshad number
        bool isHarshad = IsHarshadNumber(number);
        Console.WriteLine("Is Harshad number: " + isHarshad);

        // Find frequency of each digit
        int[,] frequency = DigitFrequency(number);
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine("Digit " + frequency[i, 0] + ": " + frequency[i, 1]);
            }
        }
    }
}
