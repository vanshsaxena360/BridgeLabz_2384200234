using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Loop through values 6 to 9 to display the multiplication table
        for (int i = 6; i <= 9; i++)
        {
            int result = number * i;
            Console.WriteLine(number+" * "+i+" = "+result);
        }
    }
}
