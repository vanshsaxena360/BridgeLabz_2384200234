using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] multiplicationResult = new int[4]; // Array to store multiplication results

        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i; 
        }

        Console.WriteLine("Multiplication Table of " + number + " from 6 to 9:");
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 6]);
        }
    }
}