using System;

public class NumberChecker
{
    // count digits in a number
    public static int Count(int number)
    {
        return number.ToString().Length;
    }

    // store digits in an array
    public static int[] GetDigits(int number)
    {
        string numStr = Math.Abs(number).ToString(); // handle negatives
        int[] digits = new int[numStr.Length];
        for (int i = 0; i < numStr.Length; i++)
        {
            digits[i] = int.Parse(numStr[i].ToString());
        }
        return digits;
    }

    // check if the number is a duck number
    public static bool IsDuck(int number)
    {
        if (number <= 0) return false; // must be positive
        string numStr = number.ToString();
        return numStr.Contains("0");
    }

    // check if the number is an armstrong number
    public static bool IsArmstrong(int number)
    {
        int[] digits = GetDigits(number);
        int power = digits.Length;
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, power);
        }
        return sum == number;
    }

    // find the largest and second largest digit
    public static void FindLargest(int[] digits, out int largest, out int secondLargest)
    {
        largest = int.MinValue;
        secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
    }

    // find the smallest and second smallest digit
    public static void FindSmallest(int[] digits, out int smallest, out int secondSmallest)
    {
        smallest = int.MaxValue;
        secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int count = Count(number);
        Console.WriteLine("Number of digits: " + count);

        int[] digits = GetDigits(number);
        Console.WriteLine("Digits of the number: " + string.Join(", ", digits));

        Console.WriteLine("Is duck number: " + IsDuck(number));
        Console.WriteLine("Is armstrong number: " + IsArmstrong(number));

        // Declare the variables before calling the methods
		int largest, secondLargest;
		FindLargest(digits, out largest, out secondLargest);
		Console.WriteLine("Largest digit: " + largest + ", Second largest digit: " + secondLargest);

		int smallest, secondSmallest;
		FindSmallest(digits, out smallest, out secondSmallest);
		Console.WriteLine("Smallest digit: " + smallest + ", Second smallest digit: " + secondSmallest);

    }
}
