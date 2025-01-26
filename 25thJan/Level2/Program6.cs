using System;

public class BMICalculator
{
    public static void Main(string[] args)
    {
        // Take input for the number of persons
        Console.WriteLine("Enter the number of persons:");
        int numberOfPersons = int.Parse(Console.ReadLine());

        // Create arrays to store data
        double[] weights = new double[numberOfPersons];
        double[] heights = new double[numberOfPersons];
        double[] bmis = new double[numberOfPersons];
        string[] weightStatuses = new string[numberOfPersons];

        // Input weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("Enter weight of person "+(i + 1));
            weights[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height (in meters) of person "+(i + 1));
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Calculate BMI and determine weight status
        for (int i = 0; i < numberOfPersons; i++)
        {
            bmis[i] = weights[i] / (heights[i] * heights[i]); // BMI = weight / height²

            if (bmis[i] < 18.4)
                weightStatuses[i] = "Underweight";
            else if (bmis[i] >= 18.5 && bmis[i] <= 24.9)
                weightStatuses[i] = "Normal weight";
            else if (bmis[i] >= 25 && bmis[i] <= 39.9)
                weightStatuses[i] = "Overweight";
            else
                weightStatuses[i] = "Obesity";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\tHeight(m)\tWeight(kg)\tBMI\t\tWeight Status");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine(i + 1 + "\t" + heights[i].ToString("F2") + "\t\t" + weights[i].ToString("F2") + "\t\t" + bmis[i].ToString("F2") + "\t\t" + weightStatuses[i]);
		}
    }
}
