using System;

class HandshakesCalculator
{
    static void Main()
    {
        // Prompt the user to enter the number of students.
        Console.Write("Enter the number of students: ");
        // Read the user input and convert it to an integer.
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the combination formula: (n * (n - 1)) / 2
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Display the result in a user-friendly format.
        Console.WriteLine("The maximum number of handshakes among "+numberOfStudents+" students is "+handshakes);
    }
}
