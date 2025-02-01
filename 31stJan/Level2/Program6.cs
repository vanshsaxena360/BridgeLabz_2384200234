using System;

class FactorialCalculator
{
    // Recursive method to calculate factorial
    public static long CalculateFactorial(int n){
        if (n == 0 || n == 1)
            return 1; // Base case
        return n * CalculateFactorial(n - 1); // Recursive call
    }

    // Main method for user input and displaying output
    public static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        // Compute factorial
        long factorial = CalculateFactorial(number);

        // Display result
        Console.WriteLine("Factorial of your no. is: "+factorial);
    }
}
