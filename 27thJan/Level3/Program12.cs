using System;

class StudentScorecard
{
    static Random rand = new Random();

    // Method to generate random scores for Physics, Chemistry, and Math
    static int[,] GenerateScores(int numStudents)
    {
        int[,] scores = new int[numStudents, 3];

        for (int i = 0; i < numStudents; i++)
        {
            scores[i, 0] = rand.Next(40, 101); // Physics
            scores[i, 1] = rand.Next(40, 101); // Chemistry
            scores[i, 2] = rand.Next(40, 101); // Math
        }

        return scores;
    }

    // Method to calculate total, average, and percentage for each student
    static double[,] CalculateResults(int[,] scores)
    {
        int numStudents = scores.GetLength(0);
        double[,] results = new double[numStudents, 3];

        for (int i = 0; i < numStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = Math.Round(total / 3.0, 2);
            double percentage = Math.Round((total / 300.0) * 100, 2);

            results[i, 0] = total;
            results[i, 1] = average;
            results[i, 2] = percentage;
        }

        return results;
    }

    // Method to display the scorecard
    static void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("\nScorecard:");
        Console.WriteLine("Student\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.WriteLine(i + 1 + "\t" + scores[i, 0] + "\t" + scores[i, 1] + "\t\t" + 
                              scores[i, 2] + "\t" + results[i, 0] + "\t" + results[i, 1] + "\t" + results[i, 2] + "%");
        }
    }

    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        int[,] scores = GenerateScores(numStudents);
        double[,] results = CalculateResults(scores);

        DisplayScorecard(scores, results);
    }
}
