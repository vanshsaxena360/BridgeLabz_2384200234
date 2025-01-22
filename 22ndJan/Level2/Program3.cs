using System;

class DoubleOpt
{
    static void Main()
    {
        // Declare variables to store user input as double
        double a, b, c;

        // Take user input for a, b, and c (double values)
        Console.Write("Enter the value of a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        c = Convert.ToDouble(Console.ReadLine());

        // Perform the double operations based on operator precedence
        double result1 = a + b * c;  // Multiplication has higher precedence than addition
        double result2 = a * b + c;  // Multiplication has higher precedence than addition
        double result3 = c + a / b;  // Division has higher precedence than addition
        double result4 = a % b + c;  // Modulus has higher precedence than addition (modulus with doubles)

        // Output the results of the operations
        Console.WriteLine("The results of Double Operations are "+result1+", "+result2+", "+result3+" and "+result4);
    }
}
