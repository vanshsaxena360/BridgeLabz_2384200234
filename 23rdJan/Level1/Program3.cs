using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        // Prompt the user to enter the third number
        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Check if the first number is the largest
        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine("Is the first number the largest? Yes");
        }
        else
        {
            Console.WriteLine("Is the first number the largest? No");
        }

        // Check if the second number is the largest
        if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine("Is the second number the largest? Yes");
        }
        else
        {
            Console.WriteLine("Is the second number the largest? No");
        }

        // Check if the third number is the largest
        if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine("Is the third number the largest? Yes");
        }
        else
        {
            Console.WriteLine("Is the third number the largest? No");
        }
    }
}
