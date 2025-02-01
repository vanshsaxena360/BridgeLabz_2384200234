using System;

public class FibonacciGenerator
{
    // Method to generate Fibonacci sequence
    public static void GenerateFibonacci(int terms){
        int first = 0, second = 1, next;

        if (terms <= 0){
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        Console.WriteLine("Fibonacci Sequence:");
        
        for (int i = 1; i <= terms; i++){
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }

        Console.WriteLine(); // Move to next line after printing sequence
    }

    public static void Main()
    {
        // Get user input for number of terms
        Console.Write("Enter the number of Fibonacci terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        // Call method to generate Fibonacci sequence
        GenerateFibonacci(terms);
    }
}
