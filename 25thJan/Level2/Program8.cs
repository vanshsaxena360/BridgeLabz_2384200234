using System;

public class StudentGrades
{
    public static void Main(string[] args)
    {
        // Take input for the number of students
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Create arrays to store marks, percentages, grades, and remarks
        int[,] marks = new int[numberOfStudents, 3]; // 3 subjects: Physics, Chemistry, Math
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];
        string[] remarks = new string[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("\nEnter marks for student "+(i + 1));

            // Input marks for Physics
            Console.WriteLine("Physics:");
            int physicsMarks = int.Parse(Console.ReadLine());
            while (physicsMarks < 0 || physicsMarks > 100)
            {
                Console.WriteLine("Please enter valid marks (0-100):");
                physicsMarks = int.Parse(Console.ReadLine());
            }
            marks[i, 0] = physicsMarks;

            // Input marks for Chemistry
            Console.WriteLine("Chemistry:");
            int chemistryMarks = int.Parse(Console.ReadLine());
            while (chemistryMarks < 0 || chemistryMarks > 100)
            {
                Console.WriteLine("Please enter valid marks (0-100):");
                chemistryMarks = int.Parse(Console.ReadLine());
            }
            marks[i, 1] = chemistryMarks;

            // Input marks for Math
            Console.WriteLine("Math:");
            int mathMarks = int.Parse(Console.ReadLine());
            while (mathMarks < 0 || mathMarks > 100)
            {
                Console.WriteLine("Please enter valid marks (0-100):");
                mathMarks = int.Parse(Console.ReadLine());
            }
            marks[i, 2] = mathMarks;

            // Calculate percentage
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = (totalMarks / 3.0);

            // Determine grade and remarks based on percentage
            if (percentages[i] >= 80)
            {
                grades[i] = "A";
                remarks[i] = "Level 4, above agency-normalized standards";
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = "B";
                remarks[i] = "Level 3, at agency-normalized standards";
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = "C";
                remarks[i] = "Level 2, below but approaching agency-normalized standards";
            }
            else if (percentages[i] >= 50)
            {
                grades[i] = "D";
                remarks[i] = "Level 1, well below agency-normalized standards";
            }
            else if (percentages[i] >= 40)
            {
                grades[i] = "E";
                remarks[i] = "Level 1-, too below agency-normalized standards";
            }
            else
            {
                grades[i] = "R";
                remarks[i] = "Remedial standards";
            }
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMath\tPercentage\tGrade\tRemarks");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine((i + 1)+"\t"+marks[i, 0]+"\t"+marks[i, 1]+"\t\t"+marks[i, 2]+"\t"+percentages[i].ToString("F2")+"\t\t"+grades[i]+"\t"+remarks[i]);
        }
    }
}
