using System;

class IntOperation
{
    static void Main()
    {
        // Declare variables to store user input
        int a, b, c;

        // Take user input for a, b, and c
        Console.Write("Enter the value of a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        c = Convert.ToInt32(Console.ReadLine());

        // Perform the integer operations based on precedence
        int result1 = a + b * c;  // Multiplication has higher precedence than addition
        int result2 = a * b + c;  // Multiplication has higher precedence than addition
        int result3 = c + a / b;  // Division has higher precedence than addition
        int result4 = a % b + c;  // Modulus has higher precedence than addition

        // Output the results of the operations
        Console.WriteLine("The results of Int Operations are "+result1+", "+result2+", "+result3+" and "+result4);
    }
}
