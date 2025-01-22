using System;

class Program
{
    static void Main()
    {
        // Declare and initialize the total number of pens to be distributed.
        int totalPens = 14;

        // Declare and initialize the number of students among whom the pens will be distributed.
        int numberOfStudents = 3;

        // Calculate the number of pens each student will get by performing integer division.
        // The division operator '/' calculates how many times the divisor fits into the dividend.
        int pensPerStudent = totalPens / numberOfStudents;

        // Calculate the remaining pens that cannot be equally distributed using the modulus operator '%'.
        // The modulus operator gives the remainder of the division.
        int remainingPens = totalPens % numberOfStudents;

        // Output the results 
        Console.WriteLine("The Pen Per Student is "+pensPerStudent+" and the remaining pen not distributed is "+remainingPens);
    }
}
