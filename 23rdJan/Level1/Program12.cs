using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Check if the number is a natural number (positive integer)
        if (n >= 1)
        {
            // Compute sum using the formula n * (n + 1) / 2
            int formulaSum = n * (n + 1) / 2;

            // Compute sum using a while loop
            int whileSum = 0;
            int counter = 1;
            while (counter <= n)
            {
                whileSum += counter;
                counter++;
            }

            // Print both results
            Console.WriteLine("Sum using formula: "+formulaSum);
            Console.WriteLine("Sum using while loop: "+whileSum);

            // Compare the results
            if (formulaSum == whileSum)
            {
                Console.WriteLine("The results are correct and match!");
            }
            else
            {
                Console.WriteLine("The results do not match!");
            }
        }
        else
        {
            // If the number is not a natural number
            Console.WriteLine(n+" is not a natural number.");
        }
    }
}
