using System;

class SwapNumbers
{
    static void Main()
    {
        // Declare two variables to store the user input numbers
        double number1, number2;

        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        // Swap the numbers using a temporary variable
        double temp = number1;
        number1 = number2;
        number2 = temp;

        // Output the swapped numbers
        Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
    }
}
