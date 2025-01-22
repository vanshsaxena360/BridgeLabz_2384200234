using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        
        // Read the user's input
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        
        // Read the second input from the console and convert it into an integer
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the quotient using the division operator '/'
        int quotient = number1 / number2;

        // Calculate the remainder using the modulus operator '%'
        int remainder = number1 % number2;

        // Output the results
        Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+number1+" and "+number2);
    }
}
