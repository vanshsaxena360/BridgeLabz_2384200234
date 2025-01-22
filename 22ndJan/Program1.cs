using System;

class Program
{
    static void Main()
    {
		// Define the birth year of Harry as a constant integer value (2000).
        int birthYear = 2000;
		// Define the current year as another integer value (2024).
        int currentYear = 2024;

		// Calculate Harry's age by subtracting the birth year from the current year.
        // Calculate the age
        int harrysAge = currentYear - birthYear;

        // Output the result
        Console.WriteLine("Harry's age in "+currentYear+" is "+harrysAge);
    }
}
