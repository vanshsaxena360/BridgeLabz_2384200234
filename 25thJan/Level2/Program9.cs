using System;

public class StudentGrades2DArray
{
    public static void Main(string[] args)
    {
        // Take input for the number of students
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Create a 2D array to store marks for Physics, Chemistry, and Math
        int[,] marks = new int[numberOfStudents, 3]; // 3 columns for the 3 subjects
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];
        string[] remarks = new string[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("\nEnter marks for student "+(i + 1));

            for (int j = 0; j < 3; j++)
            {
				// here i am using one liner statement
                string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Math";
                Console.WriteLine(subject);
                int subjectMarks = int.Parse(Console.ReadLine());

                while (subjectMarks < 0 || subjectMarks > 100)
                {
                    Console.WriteLine("Please enter valid marks (0-100):");
                    subjectMarks = int.Parse(Console.ReadLine());
                }
                marks[i, j] = subjectMarks;
            }

            // Calculate percentage
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = totalMarks / 3.0;

            // Determine grade and remarks
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
