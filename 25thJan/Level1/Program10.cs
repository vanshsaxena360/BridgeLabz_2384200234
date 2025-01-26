using System;

public class FizzBuzz
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        string[] results = new string[number + 1];

        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString();
            }
        }

        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + results[i]);
        }
    }
}