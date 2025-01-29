using System;

public class NumberChecker
{
    // method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // method to check if a number is a neon number
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;

        while (square > 0)
        {
            sumOfDigits += square % 10;
            square = square / 10;
        }

        return sumOfDigits == number;
    }

    // method to check if a number is a spy number
    public static bool IsSpy(int number)
    {
        int sum = 0;
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number = number / 10;
        }

        return sum == product;
    }

    // method to check if a number is an automorphic number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        string numberStr = number.ToString();
        string squareStr = square.ToString();

        return squareStr.EndsWith(numberStr);
    }

    // method to check if a number is a buzz number
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }

    // main method to test the functionality
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // check if the number is prime
        bool prime = IsPrime(number);
        Console.WriteLine("Is prime number: " + prime);

        // check if the number is neon
        bool neon = IsNeon(number);
        Console.WriteLine("Is neon number: " + neon);

        // check if the number is spy
        bool spy = IsSpy(number);
        Console.WriteLine("Is spy number: " + spy);

        // check if the number is automorphic
        bool automorphic = IsAutomorphic(number);
        Console.WriteLine("Is automorphic number: " + automorphic);

        // check if the number is buzz
        bool buzz = IsBuzz(number);
        Console.WriteLine("Is buzz number: " + buzz);
    }
}
