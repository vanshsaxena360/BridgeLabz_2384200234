using System;

// Define a class named Program, which acts as a container for the Main method and program logic.
class Program
{
    // The Main method is the entry point of the C# program, where execution begins.
    static void Main()
    {
        // Declare and initialize variables to store Sam's marks in Maths, Physics, and Chemistry.
        int mathsMark = 94;       // Sam's mark in Maths out of 100
        int physicsMark = 95;     // Sam's mark in Physics out of 100
        int chemistryMark = 96;   // Sam's mark in Chemistry out of 100

        // Calculate the total marks obtained in all three subjects.
        // This is done by adding the marks for Maths, Physics, and Chemistry.
        int totalMarks = mathsMark + physicsMark + chemistryMark;

        // Calculate the number of subjects (Maths, Physics, Chemistry) as an integer constant.
        // This helps to divide the total marks to find the average.
        int numberOfSubjects = 3;

        // Calculate the average mark by dividing the total marks by the number of subjects.
        // Since all subjects have equal weightage, this formula gives the average mark.
        double averageMark = (double)totalMarks / numberOfSubjects;

        // Output the calculated average mark to the console 
        Console.WriteLine("Sam’s average mark in PCM is "+averageMark);
    }
}
