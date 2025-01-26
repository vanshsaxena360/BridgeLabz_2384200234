using System;

public class OddEven
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number.");
            return;
        }

        int maxEven = number / 2; // Maximum possible even numbers
        int maxOdd = number - maxEven; // Maximum possible odd numbers

        int[] evenNumbers = new int[maxEven + 1]; // Array to store even numbers
        int[] oddNumbers = new int[maxOdd]; // Array to store odd numbers

        int evenIndex = 0;
        int oddIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
        Console.WriteLine();
    }
}