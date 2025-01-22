using System;

class BasicCalculator
{
    static void Main(string[] args)
    {
        // display the message to the user for first number input
        Console.Write("Enter the first number: ");
		//taking input in number1 variable
        double number1 = Convert.ToDouble(Console.ReadLine());

        // display the message to the user for second number input
        Console.Write("Enter the second number: ");
		//read the second number as input from user
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2; 

        // Display the results
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+ number1 +" and " +number2+" is "+addition+" , " +subtraction+ " , " +multiplication+" , and "+ division);
        
	}
}