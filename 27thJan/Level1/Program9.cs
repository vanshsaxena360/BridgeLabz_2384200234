using System;

class Program
{
    // Method to find the remainder and quotient of two numbers
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        // Calculate the quotient and remainder
        int quotient = number / divisor;
        int remainder = number % divisor;

        // Return both quotient and remainder as an array
        return new int[] { quotient, remainder };
    }

    static void Main(string[] args)
    {
        // Input: Take two integers from the user
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        // Find the quotient and remainder
        int[] result = FindRemainderAndQuotient(number, divisor);

        // Output the result
        Console.WriteLine("The quotient is: "+result[0]);
        Console.WriteLine("The remainder is: "+result[1]);
    }
}
