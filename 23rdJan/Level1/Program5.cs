using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter their age
        Console.Write("Enter the person's age: ");
        int age = int.Parse(Console.ReadLine());

        // Check if the age is 18 or older
        if (age >= 18)
        {
            // Output if the person can vote
            Console.WriteLine("The person's age is "+age+" and can vote.");
        }
        else
        {
            // Output if the person cannot vote
            Console.WriteLine("The person's age is "+age+" and cannot vote.");
        }
    }
}
