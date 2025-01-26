using System;

public class FactorsOfNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int maxFactors = 10;
        int[] factors = new int[maxFactors];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index >= maxFactors)
                {
                    // Increase array size
                    maxFactors *= 2; 
                    int[] temp = new int[maxFactors];
                    Array.Copy(factors, temp, index); 
                    factors = temp; 
                }

                factors[index] = i;
                index++;
            }
        }

        Console.WriteLine("Factors of " + number + ":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();
    }
}