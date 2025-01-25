using System;

class Calculator
{
    static void Main()
    {
        // Prompt the user for the first number
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());

        // Prompt the user for the second number
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());

        // Prompt the user for the operator
        Console.Write("Enter the operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Perform the calculation using a switch statement
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: "+(first + second));
                break;

            case "-":
                Console.WriteLine("Result: "+(first - second));
                break;

            case "*":
                Console.WriteLine("Result: "+(first * second));
                break;

            case "/":
                if (second != 0) // Check to prevent division by zero
                {
                    Console.WriteLine("Result: "+(first / second));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator. Please use +, -, *, or /.");
                break;
        }
    }
}
