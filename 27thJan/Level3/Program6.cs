using System;

public class NumberChecker
{
    // method to find factors of a number
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        // store the factors in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    // method to find the greatest factor of a number
    public static int GreatestFactor(int number)
    {
        int[] factors = FindFactors(number);
        int max = factors[0];

        foreach (int factor in factors)
        {
            if (factor > max)
            {
                max = factor;
            }
        }

        return max;
    }

    // method to find the sum of the factors
    public static int SumOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;

        foreach (int factor in factors)
        {
            sum += factor;
        }

        return sum;
    }

    // method to find the product of the factors
    public static long ProductOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        long product = 1;

        foreach (int factor in factors)
        {
            product *= factor;
        }

        return product;
    }

    // method to find the product of the cubes of the factors
    public static long ProductOfCubesOfFactors(int number)
    {
        int[] factors = FindFactors(number);
        long product = 1;

        foreach (int factor in factors)
        {
            product *= (long)Math.Pow(factor, 3);
        }

        return product;
    }

    // method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;

        // add proper divisors (exclude the number itself)
        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }

        return sum == number;
    }

    // method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;

        // add proper divisors (exclude the number itself)
        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }

        return sum > number;
    }

    // method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = 0;

        // add proper divisors (exclude the number itself)
        for (int i = 0; i < factors.Length - 1; i++)
        {
            sum += factors[i];
        }

        return sum < number;
    }

    // method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int sum = 0;
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }

        return sum == number;
    }

    // helper method to calculate factorial of a number
    public static int Factorial(int number)
    {
        int fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact *= i;
        }

        return fact;
    }

    // main method to test the functionality
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // display factors
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        // greatest factor
        Console.WriteLine("Greatest Factor: " + GreatestFactor(number));

        // sum of factors
        Console.WriteLine("Sum of Factors: " + SumOfFactors(number));

        // product of factors
        Console.WriteLine("Product of Factors: " + ProductOfFactors(number));

        // product of cubes of factors
        Console.WriteLine("Product of Cubes of Factors: " + ProductOfCubesOfFactors(number));

        // check perfect number
        Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number));

        // check abundant number
        Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(number));

        // check deficient number
        Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(number));

        // check strong number
        Console.WriteLine("Is Strong Number: " + IsStrongNumber(number));
    }
}
