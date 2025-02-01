using System;

public class GCDLCMCalculator
{
    // Method to calculate GCD using Euclidean Algorithm
    public static int CalculateGCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a; // GCD
    }

    // Method to calculate LCM using the formula: LCM(a, b) = (a * b) / GCD(a, b)
    public static int CalculateLCM(int a, int b){
        return (a / CalculateGCD(a, b)) * b; // To prevent overflow
    }

    // Main method for user input and displaying output
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int num1=int.Parse(Console.ReadLine());
		
        Console.Write("Enter second number: ");
        int num2=int.Parse(Console.ReadLine());

        // Compute GCD and LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2);

        // Display results
        Console.WriteLine("\nGCD of your numbers is: "+gcd);
        Console.WriteLine("LCM of your numbers is: "+lcm);
    }
}
