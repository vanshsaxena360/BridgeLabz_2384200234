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

        // Check if the first number is the smallest
        if (number1 < number2 && number1 < number3)
        {
            // Output if the first number is the smallest
            Console.WriteLine("Is the first number the smallest? Yes");
        }
        else
        {
            // Output if the first number is not the smallest
            Console.WriteLine("Is the first number the smallest? No");
        }
    }
}
